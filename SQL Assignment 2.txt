use SqlAssignment1DB
select * from EMP
select * from DEPT


select EMPNO,ENAME from EMP 
where EMPNO in (select MGR from EMP)



select ENAME,SAL from EMP
where ENAME = 'MILLER' or ENAME = 'SMITH'



select ENAME,SAL from EMP
where SAL > 1000



select ENAME,SAL from EMP
where ENAME <> 'JAMES'



select * from EMP
where ENAME like 'S%'



select ENAME 'Employees that have "A" anywhere in their Name.' from EMP 
where ENAME like '%A%'



select ENAME 'Employee thet have "L" as their Third Character.' from EMP
where ENAME like '__L%'



select * from EMP
where ENAME like 'A%' or ENAME like 'M%'



select ENAME,SAL,(SAL*12)'Annual Salary' from EMP
where ENAME = 'SMITH'



select ENAME,SAL,(SAL/30)'Daily Salary' from EMP
where ENAME = 'Jones'



select sum(SAL)'Total Monthly Salary of All Employee' from EMP



select  avg(SAL*12) 'Average Annual Salary' from EMP



select ENAME,JOB,SAL,DEPTNO from EMP
where JOB <> 'SALESMAN' and DEPTNO = 30



select distinct(DEPTNO) 'Unique Department ID in Employee Table.' from EMP



select ENAME 'Employee',SAL 'Monthly Salary',DEPTNO from EMP
where SAL > 1500 and (DEPTNO = 10 or DEPTNO = 30)