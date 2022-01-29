Report1 rpt=new Report1();
//Open Main Report
rpt.RecordSelectionFormula = "{EQReport;1.OB}<>0 or {EQReport;1.CB}<>0 or {EQReport;1.Pipe KG}<>0  or {EQReport;1.Recptis}<> 0or {EQReport;1.max_month_payments}<>0";
//Open Sub Report
rpt.OpenSubreport("separate_rpt").RecordSelectionFormula = "{Command.OB}<>0 or {Command.CB}<>0 or {Command.Pipe KG}<>0  or {Command.Recptis}<>0 or {Command.max_month_payments}<>0";
