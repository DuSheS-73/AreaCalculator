USE [MindboxTest]
GO

SELECT 
[product].[Name],
[category].[Name]
FROM [dbo].[Products] [product]
LEFT JOIN [dbo].[ProductsInCategories] [productInCategory] ON [product].[id] = [productInCategory].[ProductId]
LEFT JOIN [dbo].[Categories] [category] ON [productInCategory].[CategoryId] = [category].[id]