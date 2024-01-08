create proc sp_insertoynanan
(
@tarih DateTime,
@kazanan nvarchar(10),
@kaybeden nvarchar(10)
)
as
begin
INSERT INTO [dbo].[oynanan]
           ([tarih]
           ,[kazanan]
           ,[kaybeden])
     VALUES
           (@tarih
           ,@kazanan
		   ,@kaybeden)
end


