USE [GETANSWER]
GO

/****** Object:  View [dbo].[VW_TAG]    Script Date: 2/20/2019 11:53:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[VW_TAG]
AS
SELECT tg.Id, tg.Name, 2 as Type,Count(1) as Count, tg.Count as FullCount FROM Question qn
INNER JOIN QuestionTag qt on qn.Id=qt.QuestionId
INNER JOIN Tag tg on qt.TagId=tg.Id 
WHERE CreatedDate BETWEEN DATEADD( MONTH , -1, GETDATE()) AND GETDATE() GROUP BY tg.Id, tg.Name,tg.Count
UNION ALL
SELECT tg.Id,tg.Name, 2 as Type,Count(1) as Count, tg.Count as FullCount FROM Question qn
INNER JOIN QuestionTag qt on qn.Id=qt.QuestionId
INNER JOIN Tag tg on qt.TagId=tg.Id 
WHERE CreatedDate BETWEEN DATEADD( DAY , -7, GETDATE()) AND GETDATE() GROUP BY tg.Id, tg.Name,tg.Count
UNION ALL
SELECT tg.Id,tg.Name, 3 as Type, Count(1) as Count, tg.Count as FullCount FROM Question qn
INNER JOIN QuestionTag qt on qn.Id=qt.QuestionId
INNER JOIN Tag tg on qt.TagId=tg.Id 
WHERE  CAST(CreatedDate AS date) = CAST(getdate() AS date) GROUP BY tg.Id, tg.Name,tg.Count
 
 
 
GO


	