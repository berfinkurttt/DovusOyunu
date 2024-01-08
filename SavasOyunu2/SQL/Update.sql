create proc sp_updateoynanan
(
@tarih DateTime,
@kazanan nvarchar(10),
@kaybeden nvarchar(10)
)
as
begin
update dbo.oynanan set kazanan=@kazanan , kaybeden=@kaybeden where tarih=@tarih
end
