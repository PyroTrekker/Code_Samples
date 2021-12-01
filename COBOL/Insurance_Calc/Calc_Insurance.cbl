      ******************************************************************
      * Author: Graham Wenz
      * Date: 11/16/2016
      * Purpose: This subprogram accepts 3 arguments,
      *    annual_salary
      *    sick_leave_hours
      *    insurance_amount
      * calculates the amount of sick-leave salary using the 1st two,
      * and stores the result in the 3rd to be displayed in another program.
      * Tectonics: cobc
      ******************************************************************
       IDENTIFICATION DIVISION.
       PROGRAM-ID. Calc_Insurance.
       DATA DIVISION.
       FILE SECTION.
       WORKING-STORAGE SECTION.
       01    WORK-FIELDS.
      * WORK HOURS IN A YEAR = 2080
           05 WORK-HOURS PIC 9(4) VALUE 2080.

       LINKAGE SECTION.
       77  LS-ANNUAL-SALARY        PIC 9(5).
       77  LS-LEAVE-HOURS          PIC 9(3).
       77  LS-INSURANCE-AMNT       PIC $ZZZZ9.99.

       PROCEDURE DIVISION USING LS-ANNUAL-SALARY
                                LS-LEAVE-HOURS
                                LS-INSURANCE-AMNT.
       000-CALCULATE-INSURANCE.
           COMPUTE LS-INSURANCE-AMNT ROUNDED =
               LS-LEAVE-HOURS * (LS-ANNUAL-SALARY / WORK-HOURS)

           EXIT PROGRAM.
