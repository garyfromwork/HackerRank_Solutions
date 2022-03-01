SELECT ROUND( 
    AVG(salary) - AVG(
        TO_NUMBER( 
            REPLACE( 
                TO_CHAR(salary),'0')
        )
    )+.5,0
)
FROM employees;