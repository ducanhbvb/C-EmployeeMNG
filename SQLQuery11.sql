/****** Script for SelectTopNRows command from SSMS  ******/
SELECT Id
      ,Code
      ,EmployeeId
      ,Name
      ,Branch
      ,Note
  FROM BankAccount
  WHERE EmployeeId = @PeopleId;
