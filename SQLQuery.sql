select si.SEngineNo as 'Engine No' , ns.CPhone as 'Customer Phone' , si.SDate as 'Buy Date' ,  ns.CDate as 'Sell Date' 
from dbo.stockinfo si join dbo.netsellinginfo ns on si.sengineno = ns.sengineno ;

