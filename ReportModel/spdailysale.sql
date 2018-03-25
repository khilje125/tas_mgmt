USE [StockDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetTotalSaleByDate]    Script Date: 3/25/2018 2:12:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[sp_GetDailySaleDetailReport] --'01-08-2018','01-09-2018'

  @FromDate varchar(20),       
  @ToDate varchar(20)  

AS

	  select o.ORDER_DATE,o.ORD_ID,c.FIRST_NAME,o.invoiceTotal as Sale,

  (case  when o.PaymentType ='On-Cash' then cast(o.invoiceTotal as nvarchar) else  '' end)as Oncash,
  (case  when o.PaymentType ='On-Credit' then cast(o.invoiceTotal as nvarchar) else  '' end)as OnCredit,
    (case  when o.PaymentType ='On-Cheque' then cast(o.invoiceTotal as nvarchar) else  '' end)as OnCheque,
	 (case  when o.PaymentType ='On-Cash & Cheque' then cast(o.invoiceTotal as nvarchar) else  '' end)as OnCashCheque,
	  (case  when o.PaymentType ='On-Cash & Credit' then cast(o.invoiceTotal as nvarchar) else  '' end)as OnCashCredit,
	  SUM(o.invoiceTotal) OVER(ORDER BY o.[ORD_ID] 
     ROWS BETWEEN UNBOUNDED PRECEDING AND CURRENT ROW) 
          AS RunningTotal
   from [ORDER] o
  inner join CUSTOMER c on c.CUST_ID = o.CUST_ID
 -- where o.ORDER_DATE = '02-06-2018'=> '02-08-2018'  
  WHERE  (cast(o.ORDER_DATE as date) >= cast(@FromDate as date) and cast(o.ORDER_DATE as date) <= cast(@ToDate as date)) 
  order by o.ORD_ID 