create proc sp_deteoynanan
(
@tarih DateTime
)
as
begin
delete from dbo.oynanan where tarih=@tarih
end