      ******************************************************************
      * Author: Graham Wenz
      * Date: 11/02/2016
      * Purpose: This program prepares and prints a report file on YMCA Members
      * Tectonics: cobc
      *
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. YMCA-MEMBERS-REPORT.

       ENVIRONMENT DIVISION.

       CONFIGURATION SECTION.

       INPUT-OUTPUT SECTION.

       FILE-CONTROL.
           SELECT YMCAMEM ASSIGN TO "E:\YMCAMEM.txt"
               ORGANIZATION IS LINE SEQUENTIAL.
           SELECT MEMBERRPT ASSIGN TO "E:\MEMBERRPT.txt"
               ORGANIZATION IS LINE SEQUENTIAL.

       DATA DIVISION.

       FILE SECTION.

       FD  YMCAMEM.
       01  MEMBER-MASTER-RECORD.
           05  MBR-STATUS              PIC X(8).
           05  MBR-PERSONAL-TRAINER    PIC X(8).
           05  MBR-CARD-NUMBER         PIC 9(6).
           05  MBR-NAME                PIC X(20).
           05  MBR-FAV-ACTIVITY        PIC X(10).
           05  MBR-MEMBERSHIP-FEES     PIC 9(3)V9(2).
           05  MBR-CLASS-FEES          PIC 9(3)V9(2).
           05  MBR-MASSAGE-FEES        PIC 9(3)V9(2).
           05  MBR-FITNESS-SCORE       PIC 9(3)V9(2).
           05  MBR-ZIPCODE             PIC 9(5).
           05  MMR-FILE-DATE           PIC 9(8).
           05  MMR-FILE-DATE-X       REDEFINES MMR-FILE-DATE.
               10  MMR-YEAR                 PIC 9(4).
               10  MMR-MONTH                PIC 99.
               10  MMR-DAY                  PIC 99.

       FD  MEMBERRPT.
       01  MEM-REPORT                  PIC X(132).

       WORKING-STORAGE SECTION.

       01  SWITCHES.
           05  EOF-SWITCH                  PIC X          VALUE "N".
               88  EOF                                    VALUE "Y".
           05  FIRST-RECORD-SWITCH         PIC X          VALUE "Y".
               88  FIRST-RECORD                           VALUE "Y".

       01  PRINT-FIELDS                BINARY.
           05  PAGE-COUNT              PIC S99        VALUE ZEROES.
           05  LINES-ON-PAGE           PIC S99        VALUE +4.
           05  LINES-COUNT             PIC S99        VALUE +99.
           05  RECORD-COUNT            PIC S99        VALUE ZEROES.

       01  STATUS-TRACKERS.
           05  OLD-STATUS              PIC X(8).
           05  OLD-TRAINER             PIC X(8).

       01  TOTAL-FIELDS                PACKED-DECIMAL.
           05  TOTAL-MEMBERSHIP-FEES   PIC S9(5)V99   VALUE ZERO.
           05  TOTAL-CLASS-FEES        PIC S9(5)V99   VALUE ZERO.
           05  TOTAL-MASSAGE-FEES      PIC S9(5)V99   VALUE ZERO.
           05  TOTAL-FITNESS-SCORE     PIC S9(5)V99   VALUE ZERO.

       01  CURRENT-DATE-AND-TIME.
           05  CD-CURRENT-DATE         PIC 9(8).
           05  CD-CURRENT-DATE-X       REDEFINES CD-CURRENT-DATE.
               10  CD-YEAR                 PIC 9(4).
               10  CD-MONTH                PIC 99.
               10  CD-DAY                  PIC 99.

           05  CD-CURRENT-TIME         PIC 9(4).
           05  CD-CURRENT-TIME-X       REDEFINES CD-CURRENT-TIME.
               10  CD-HOURS                PIC 99.
               10  CD-MINUTES              PIC 99.

           05   CD-DAY-OF-WEEK        PIC 9.
           05   CD-DAY-NAME           PIC X(9).

      *HL1-DATE-X REDEFINE CLAUSE REFORMATS CURRENT-DATE FROM YYYYMMDD TO MM/DD/YYYY
       01  HEADING-LINE-1.
           05                          PIC X(7)        VALUE "DATE:  ".
           05  HL1-DATE                PIC 99/99/9999.
           05  HL1-DATE-X              REDEFINES HL1-DATE.
               10  HL1-MONTH           PIC 99.
               10                      PIC X.
               10  HL1-DAY             PIC 99.
               10                      PIC X.
               10  HL1-YEAR            PIC 9(4).
           05              PIC X(25)       VALUE SPACE.
           05              PIC X(20)       VALUE "YMCA-MEMBER-FITNESS-".
           05              PIC X(20)       VALUE "SCORES-REPORT       ".
           05              PIC X(6)        VALUE SPACE.
           05              PIC X(20)       VALUE "              PAGE: ".
           05  HL1-PAGE-NUMBER         PIC ZZZ9.

       01  HEADING-LINE-2.
           05              PIC X(7)        VALUE "TIME:  ".
           05  HL2-HOURS   PIC 9(2).
           05              PIC X(1)        VALUE ":".
           05  HL2-MINUTES PIC 9(2).
           05              PIC X(4)        VALUE SPACE.

       01  HEADING-LINE-22.
           05               PIC X(6)        VALUE "DAY:  ".
           05  HL22-WEEKDAY PIC X(9).
           05               PIC X(4)        VALUE SPACE.
           05               PIC X(5)        VALUE "AGE: ".
           05  HL22-AGE     PIC ZZ9(3).
           05               PIC X(6)        VALUE " YEARS".

       01  HEADING-LINE-3.
           05              PIC X(20)       VALUE "MEMBER    PERSONAL  ".
           05              PIC X(20)       VALUE "CARD                ".
           05              PIC X(20)       VALUE "          FAVORITE  ".
           05              PIC X(20)       VALUE "   MEMBERSHIP   CLAS".
           05              PIC X(20)       VALUE "S     MASSAGE    FIT".
           05              PIC X(4)        VALUE "NESS".

       01  HEADING-LINE-4.
           05              PIC X(20)       VALUE "STATUS    TRAINER   ".
           05              PIC X(20)       VALUE "NUM     MEMBER NAME ".
           05              PIC X(20)       VALUE "          ACTIVITY  ".
           05              PIC X(20)       VALUE "     FEES        FEE".
           05              PIC X(20)       VALUE "S        FEES      S".
           05              PIC X(20)       VALUE "CORE   ZIPCODE      ".

       01  MEMBER-LINE.
           05  ML-MEMBER-STATUS        PIC X(8).
           05                          PIC X(2)        VALUE SPACE.
           05  ML-PERSONAL-TRAINER     PIC X(8).
           05                          PIC XX          VALUE SPACE.
           05  ML-CARD-NUMBER          PIC 9(6).
           05                          PIC XX          VALUE SPACE.
           05  ML-MEMBER-NAME          PIC X(20).
           05                          PIC XX          VALUE SPACE.
           05  ML-FAV-ACTIVITY         PIC X(10).
           05                          PIC XX          VALUE SPACE.
           05  ML-MEMBERSHIP-FEES      PIC $ZZ9.99.
           05                          PIC X(5)        VALUE SPACE.
           05  ML-CLASS-FEES           PIC $ZZ9.99.
           05                          PIC X(5)        VALUE SPACE.
           05  ML-MASSAGE-FEES         PIC $ZZ9.99.
           05                          PIC X(5)        VALUE SPACE.
           05  ML-FITNESS-SCORE        PIC ZZZ.99.
           05                          PIC X(3)        VALUE SPACE.
           05  ML-ZIP                  PIC 9(5).

       01  AVERAGE-SCORE-LINE.
           05              PIC X(20)       VALUE "AVERAGES            ".
           05                          PIC X(39)       VALUE SPACE.
           05 AS-AVRG-MEMBERSHIP-FEES  PIC $ZZ,ZZ9.99.
           05                          PIC X(2)        VALUE SPACE.
           05 AS-AVRG-CLASS-FEES       PIC $ZZ,ZZ9.99.
           05                          PIC X(2)        VALUE SPACE.
           05 AS-AVRG-MASSAGE-FEES     PIC $ZZ,ZZ9.99.
           05                          PIC X(2)        VALUE SPACE.
           05 AS-AVRG-FITNESS-SCORE    PIC ZZ,ZZZ.99.

       01  TOTAL-SCORE-LINE.
           05              PIC X(20)       VALUE "TOTALS              ".
           05                          PIC X(39)       VALUE SPACE.
           05 TS-TOTAL-MEMBERSHIP-FEES PIC $ZZ,ZZ9.99.
           05                          PIC X(2)        VALUE SPACE.
           05 TS-TOTAL-CLASS-FEES      PIC $ZZ,ZZ9.99.
           05                          PIC X(2)        VALUE SPACE.
           05 TS-TOTAL-MASSAGE-FEES    PIC $ZZ,ZZ9.99.
           05                          PIC X(2)        VALUE SPACE.
           05 TS-TOTAL-FITNESS-SCORE   PIC ZZ,ZZZ.99.

       PROCEDURE DIVISION.

       000-PREPARE-MEMBER-REPORT.
           OPEN INPUT  YMCAMEM
                OUTPUT MEMBERRPT.
           PERFORM 100-FORMAT-REPORT-HEADING.
           PERFORM 300-PREPARE-MEMBER-LINES
               WITH TEST AFTER
               UNTIL EOF.
           PERFORM 500-PRINT-AVERAGE-LINE.
           PERFORM 510-PRINT-TOTAL-LINE.
           CLOSE   YMCAMEM
                   MEMBERRPT.


       STOP RUN.

       100-FORMAT-REPORT-HEADING.
      *MOVE CURRENT DATE AND TIME TO HEADING
           MOVE FUNCTION CURRENT-DATE TO CURRENT-DATE-AND-TIME.
           MOVE CD-MONTH              TO HL1-MONTH.
           MOVE CD-DAY                TO HL1-DAY.
           MOVE CD-YEAR               TO HL1-YEAR.
           MOVE CD-HOURS              TO HL2-HOURS.
           MOVE CD-MINUTES            TO HL2-MINUTES.
           ACCEPT CD-DAY-OF-WEEK FROM DAY-OF-WEEK.
               EVALUATE CD-DAY-OF-WEEK
                   WHEN 1 MOVE "MONDAY" TO CD-DAY-NAME
                   WHEN 2 MOVE "TUESDAY" TO CD-DAY-NAME
                   WHEN 3 MOVE "WEDNESDAY" TO CD-DAY-NAME
                   WHEN 4 MOVE "THURSDAY" TO CD-DAY-NAME
                   WHEN 5 MOVE "FRIDAY" TO CD-DAY-NAME
                   WHEN 6 MOVE "SATURDAY" TO CD-DAY-NAME
                   WHEN 0 MOVE "SUNDAY" TO CD-DAY-NAME
               END-EVALUATE.
           MOVE CD-DAY-NAME TO HL22-WEEKDAY.

       300-PREPARE-MEMBER-LINES.
           PERFORM 310-READ-MEMBER-RECORD.

           IF NOT EOF
               IF FIRST-RECORD
                   PERFORM 340-PRINT-STATUS-LINE
                   PERFORM 350-PRINT-TRAINER-LINE
                   COMPUTE HL22-AGE =
                       CD-YEAR - MMR-YEAR
                   PERFORM 320-PRINT-MEMBER-LINE
                   MOVE "N" TO FIRST-RECORD-SWITCH
                   MOVE MBR-STATUS TO OLD-STATUS
                   MOVE MBR-PERSONAL-TRAINER TO OLD-TRAINER

               ELSE
                   IF MBR-STATUS NOT EQUALS OLD-STATUS
                       PERFORM 340-PRINT-STATUS-LINE
                       PERFORM 350-PRINT-TRAINER-LINE
                       PERFORM 320-PRINT-MEMBER-LINE
                       MOVE MBR-STATUS TO OLD-STATUS
                       MOVE MBR-PERSONAL-TRAINER TO OLD-TRAINER
                   ELSE
                       IF MBR-PERSONAL-TRAINER NOT EQUALS OLD-TRAINER
                           PERFORM 350-PRINT-TRAINER-LINE
                           PERFORM 320-PRINT-MEMBER-LINE
                           MOVE MBR-PERSONAL-TRAINER TO OLD-TRAINER
                       ELSE
                           MOVE SPACES TO ML-MEMBER-STATUS
                           MOVE SPACES TO ML-PERSONAL-TRAINER
                           PERFORM 320-PRINT-MEMBER-LINE
                       END-IF
                   END-IF
               END-IF
           END-IF.

       310-READ-MEMBER-RECORD.
           READ YMCAMEM
               AT END
                   MOVE "Y" TO EOF-SWITCH.

       320-PRINT-MEMBER-LINE.
      *PRINT HEADING LINES
           IF LINES-COUNT >= LINES-ON-PAGE
               PERFORM 330-PRINT-HEADING-LINES.

      *PRINT MEMBER LINE
           MOVE MBR-CARD-NUMBER        TO ML-CARD-NUMBER.
           MOVE MBR-NAME               TO ML-MEMBER-NAME.
           MOVE MBR-FAV-ACTIVITY       TO ML-FAV-ACTIVITY.
           MOVE MBR-MEMBERSHIP-FEES    TO ML-MEMBERSHIP-FEES.
           MOVE MBR-CLASS-FEES         TO ML-CLASS-FEES.
           MOVE MBR-MASSAGE-FEES       TO ML-MASSAGE-FEES.
           MOVE MBR-FITNESS-SCORE      TO ML-FITNESS-SCORE.
           MOVE MBR-ZIPCODE            TO ML-ZIP.
           MOVE MEMBER-LINE            TO MEM-REPORT.

           WRITE MEM-REPORT AFTER ADVANCING 1 LINES.

           ADD 1                       TO LINES-COUNT.
           ADD 1                       TO RECORD-COUNT.
           ADD MBR-MEMBERSHIP-FEES     TO TOTAL-MEMBERSHIP-FEES.
           ADD MBR-CLASS-FEES          TO TOTAL-CLASS-FEES.
           ADD MBR-MASSAGE-FEES        TO TOTAL-MASSAGE-FEES.
           ADD MBR-FITNESS-SCORE       TO TOTAL-FITNESS-SCORE.

       330-PRINT-HEADING-LINES.

           ADD 1 TO PAGE-COUNT.
           MOVE PAGE-COUNT                 TO HL1-PAGE-NUMBER.

           IF PAGE-COUNT > 1
               MOVE HEADING-LINE-1         TO MEM-REPORT
               WRITE MEM-REPORT AFTER ADVANCING PAGE
           ELSE
               MOVE HEADING-LINE-1         TO MEM-REPORT
               WRITE MEM-REPORT.

           MOVE HEADING-LINE-2             TO MEM-REPORT.
           IF PAGE-COUNT = 1
               MOVE HEADING-LINE-22        TO MEM-REPORT.
               WRITE MEM-REPORT.
           MOVE HEADING-LINE-3             TO MEM-REPORT.
           WRITE MEM-REPORT AFTER ADVANCING 1 LINES.
           MOVE HEADING-LINE-4             TO MEM-REPORT.
           WRITE MEM-REPORT.
           MOVE ZERO                       TO LINES-COUNT.

       340-PRINT-STATUS-LINE.
           MOVE MBR-STATUS TO ML-MEMBER-STATUS.

       350-PRINT-TRAINER-LINE.
           MOVE MBR-PERSONAL-TRAINER TO ML-PERSONAL-TRAINER.

       500-PRINT-AVERAGE-LINE.

           DIVIDE TOTAL-MEMBERSHIP-FEES BY RECORD-COUNT
               GIVING AS-AVRG-MEMBERSHIP-FEES ROUNDED.
           DIVIDE TOTAL-CLASS-FEES BY RECORD-COUNT
               GIVING AS-AVRG-CLASS-FEES ROUNDED.
           DIVIDE TOTAL-MASSAGE-FEES BY RECORD-COUNT
               GIVING AS-AVRG-MASSAGE-FEES ROUNDED.
           DIVIDE TOTAL-FITNESS-SCORE BY RECORD-COUNT
               GIVING AS-AVRG-FITNESS-SCORE ROUNDED.
           MOVE AVERAGE-SCORE-LINE TO MEM-REPORT.
           WRITE MEM-REPORT AFTER ADVANCING 1 LINES.

       510-PRINT-TOTAL-LINE.

           MOVE TOTAL-MEMBERSHIP-FEES  TO TS-TOTAL-MEMBERSHIP-FEES.
           MOVE TOTAL-CLASS-FEES       TO TS-TOTAL-CLASS-FEES.
           MOVE TOTAL-MASSAGE-FEES     TO TS-TOTAL-MASSAGE-FEES.
           MOVE TOTAL-FITNESS-SCORE    TO TS-TOTAL-FITNESS-SCORE.
           MOVE TOTAL-SCORE-LINE TO MEM-REPORT.
           WRITE MEM-REPORT AFTER ADVANCING 1 LINES.
