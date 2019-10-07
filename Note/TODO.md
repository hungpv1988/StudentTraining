Student Framework
1. Expose Core API in StudentLib (1) Business Rules (2) ValidationService

2. FU: remove businessrule that only Male is accepted
       Grade at high school > 7.0
       	Allow foreign Name, meaning not restricted to only normal alphabet
	Students must have 1 billion VND in bank account

   CongAnU: Add a rule regarding profile
            Add a rule that male >=1.60 and age<23 while female >=1.55 and age < 21
	    Add a rule that grade at high school >8.0	
	    Students should have 500M in bank account				
		Moutainous areas are  added 0.2 to grades at high school.
	    If your father serves security service before, 0.2 added to grade at high school	

   BKUniversity
	   Grade at high school > 7.5
	   Allow  both male and female
	   Students from other provinces than Hanoi is added 0.1 to grade at high school
	   For students from HN, bank account must be larger than 500M, but for those ones from province, only larger  than 300M

 3. For all universities, administrators should be able to disable rules or enables rules.
	Developers should be able to  create new rules or remove old ones and admin should be able to manage rules.

 4. If possible, code one view using React.

Note: code as you do, and review your code, and refactor

Stick to SOLID principles.
		   		