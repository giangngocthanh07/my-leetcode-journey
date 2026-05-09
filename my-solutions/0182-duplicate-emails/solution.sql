-- Write your PostgreSQL query statement below
SELECT Email
FROM Person
WHERE email IS NOT NULL
GROUP BY email
HAVING COUNT(email) > 1
