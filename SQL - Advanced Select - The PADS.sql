select (name || '(' || lpad(occupation,1) || ')')
from occupations
order by name asc;

select ('There are a total of ' || count(occupation) || ' ' || lower(occupation) || 's.')
from occupations
group by occupation
order by count(occupation) asc, occupation asc;