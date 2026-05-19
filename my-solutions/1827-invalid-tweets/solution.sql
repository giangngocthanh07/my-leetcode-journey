-- Write your PostgreSQL query statement below
SELECT t.tweet_id
FROM Tweets AS t
WHERE LENGTH(t.content) > 15
