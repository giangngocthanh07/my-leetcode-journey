-- Write your PostgreSQL query statement below
SELECT today.id
FROM Weather AS today JOIN Weather AS yesterday ON today.recordDate - yesterday.recordDate = 1
WHERE today.temperature > yesterday.temperature
