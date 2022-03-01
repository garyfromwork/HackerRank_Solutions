--Write a query to print the id, age, coins_needed, and power of the wands
--sorted in order of descending power. If more than one wand has same power, sort the result in order of descending age.

SELECT A.myid,
       A.age,
       A.coins_needed,
       A.power 
FROM (
    SELECT w1.id AS myid,
           age,
           coins_needed,
           power, 
           row_number() 
     OVER(
            PARTITION BY age, 
                         power 
            ORDER BY coins_needed ASC
     ) AS rn
     FROM wands w1 
     INNER JOIN wands_property w2 
     ON w1.code = w2.code
     WHERE is_evil = 0
) A
WHERE A.rn = 1
ORDER BY power DESC, age DESC;