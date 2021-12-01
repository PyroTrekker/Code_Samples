      *************************************************************
      * Author: Graham Wenz
      * Date: 11/16/2016
      * Purpose: Allows the user to enter their annual-salary and unused sick-leave
      *          hours and calculates the salary amount to be inserted into their
      *          health insurance fund for retirment.
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. INSURANCE-CALCULATOR.
       DATA DIVISION.
       FILE SECTION.
       WORKING-STORAGE SECTION.
       01  USER-ENTRIES.
           05  ANNUAL-SALARY        PIC 9(5).
           05  LEAVE-HOURS          PIC 9(3).
       01  WORK-FIELDS.
           05  INSURANCE-AMNT       PIC $ZZZZ9.99.
       PROCEDURE DIVISION.
       MAIN-PROCEDURE.
            DISPLAY "Enter: Annual Salary"
            ACCEPT ANNUAL-SALARY

            DISPLAY "ENTER: Unused Sick-Leave Hours"
            ACCEPT LEAVE-HOURS

            CALL "Calc_Insurance" USING ANNUAL-SALARY
                                        LEAVE-HOURS
                                        INSURANCE-AMNT.
            DISPLAY "Insurance Amount: "
            DISPLAY INSURANCE-AMNT.
            STOP RUN.
