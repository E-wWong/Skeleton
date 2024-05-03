USE [p2717741]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblInventoryManagement_SelectAll]

SELECT	@return_value as 'Return Value'

GO
