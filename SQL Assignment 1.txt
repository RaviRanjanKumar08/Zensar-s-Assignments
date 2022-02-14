create database SqlAssignment1DB
use SqlAssignment1DB
create table DEPT
(DEPTNO INT primary key,
DNAME VARCHAR(20) unique,
LOC varchar(30) NOT NULL)

create table EMP
(EMPNO int primary key,
ENAME VARCHAR(30) NOT NULL,
JOB VARCHAR(20) NOT NULL,
MGR INT,
HIREDATE DATE,
SAL FLOAT,
COMM INT,
DEPTNO INT foreign key references DEPT(DEPTNO))

select * from DEPT
select * from EMP

insert into DEPT
values(10,'ACCOUNTING', 'NEW YORK'),
(20,'RESEARCH', 'DALLAS'),
(30,'SALES', 'CHICAGO'),
(40,'OPERATIONS', 'BOSTON')

insert into EMP
values(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,    'WARD'	  ,'SALESMAN',      7698    ,'22-FEB-81',  	 1250,     500    ,30),
(7566,    'JONES',     'MANAGER',       7839,    '02-APR-81',   	 2975,   NULL,  20),
(7654,    'MARTIN',    'SALESMAN',      7698,    '28-SEP-81',  	 1250,    1400,    30),
(7698,	'BLAKE', 	  'MANAGER', 	7839, 	'01-MAY-81',    	 2850,       NULL,   30),
(7782,  	'CLARK',     'MANAGER',       7839,    '09-JUN-81',   	 2450,   NULL,         10),
(7788,  	'SCOTT',     'ANALYST',       7566,    '19-APR-87',        3000,   NULL,         20),
(7839,    'KING',      'PRESIDENT',    NULL,     '17-NOV-81',        5000,   NULL,         10),
(7844,    'TURNER',   'SALESMAN',      7698,    '08-SEP-81',    	 1500,      0,     30),
(7876,    'ADAMS',     'CLERK',         7788,    '23-MAY-87',        1100,    NULL,     20),
(7900,    'JAMES',     'CLERK',         7698,    '03-DEC-81',  	  950,    NULL,        30),
(7902,    'FORD',      'ANALYST',       7566,    '03-DEC-81',   	 3000,     NULL,       20),
(7934,    'MILLER',    'CLERK',         7782,    '23-JAN-82',	 1300,    NULL,        10)

select * from EMP 
where ENAME like 'A%';




select * from EMP 
where MGR is Null;




select ENAME, EMPNO, SAL from EMP
where SAL between 1200 and 1400;




select * from EMP
where DEPTNO = 20;
update EMP set SAL = SAL + (SAL*10/100)
where DEPTNO = 20;
select * from EMP
where DEPTNO = 20




select count(JOB) 'Number of Employee of type Clerk' from EMP
where JOB = 'CLERK';




select count(*) 'Count of Employees', AVG(SAL) 'Average of Salary',JOB from EMP
group by JOB;




select * from EMP
where SAL = (select min(SAL)'Minimum Salary' from EMP)
select * from EMP
where SAL = (select  max(SAL)'Maximum Salary' from EMP)





select * from DEPT
where DEPTNO not in (select DEPTNO from EMP)





select ENAME, SAL from EMP
where JOB = 'ANALYST' and SAL > 1200 and DEPTNO = 20
order by ENAME





select DNAME, d.DEPTNO, sum(SAL)'Total Salaries in Department' from DEPT d,EMP e
where d.DEPTNO = e.DEPTNO
group by DNAME, d.DEPTNO





select ENAME, SAL from EMP
where ENAME = 'Miller' or ENAME = 'Smith';





select * from EMP 
where ENAME like 'A%' or ENAME like 'M%';





select ENAME,(SAL*12) 'Anual Salary' from EMP
where ENAME = 'Smith';





Select ENAME, SAL from EMP
where SAL not between 1500 and 2850;