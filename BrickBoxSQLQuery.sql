USE [BrickBoxContext]
GO

-- delete any existing records
delete from [BrickBoxContext].[dbo].[Inventories]
go
delete from [BrickBoxContext].[dbo].[WishLists]
go

-- insert new records
set identity_insert [BrickBoxContext].[dbo].[Inventories] on
INSERT INTO [BrickBoxContext].[dbo].[Inventories] ([inventoryID],[name],[model],[pieces],[msrp])
VALUES	(1, 'R2-D2', '10225', 2127, 179.99),
		(2, 'Volkswagen T1 Camper Van', '10220', 1332, 119.99),
		(3, 'Queen Annes Revenge', '4195', 1097, 255.45),
		(4, 'Batman Arkham Asylum Breakout', '10937', 1619, 215.85)
set identity_insert [BrickBoxContext].[dbo].[Inventories] off

set identity_insert [BrickBoxContext].[dbo].[WishLists] on
INSERT INTO [BrickBoxContext].[dbo].[WishLists] ([wishlistID],[name],[model],[pieces],[msrp])
VALUES	(1, 'The Lord of the Rings Hobbit Shelob Attacks', '9470', 227, 19.99),
		(2, 'Apple Tree House', '5891', 539 , 64.42),
		(3, 'Big Ben', '21013', 346, 29.99),
		(4, 'The Hobbit An Unexpected Gathering', '79003', 652, 69.99)
set identity_insert [BrickBoxContext].[dbo].[WishLists] off
