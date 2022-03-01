--hacker_id and name of hackers who achieved full scores for more than one challenge
--order output by descending by total number of challenges that hacker scored 100%
--if more than one hacker, then sort by asc hacker_id

SELECT hacker_id, 
       name 
FROM (
    SELECT h.hacker_id, 
           h.name, 
           count(h.hacker_id)
    FROM submissions s
    INNER JOIN challenges c
    ON s.challenge_id = c.challenge_id
    INNER JOIN difficulty d
    ON c.difficulty_level = d.difficulty_level 
    INNER JOIN hackers h
    ON s.hacker_id = h.hacker_id
    WHERE s.score = d.score
    GROUP BY h.hacker_id, h.name
    HAVING count(h.hacker_id) > 1
    ORDER BY count(h.hacker_id) desc, h.hacker_id asc
);