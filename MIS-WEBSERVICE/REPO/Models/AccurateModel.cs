﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace REPO.Models
{
    public partial class SalefileModel
    {
        public string number { get; set; }
        public DateTime invdate { get; set; }
        public string invcode { get; set; }
        public string invbook { get; set; }
        public int invno { get; set; }
        public string invname { get; set; }
        public int invdue { get; set; }
        public DateTime duedate { get; set; }
        public double invnet { get; set; }
        public double invearnamo { get; set; }
        public double invvat { get; set; }
        public double invsumtt { get; set; }
        public double invgcost { get; set; }
        public double invprofit { get; set; }
        public string invscode { get; set; }
        public double invdisp1 { get; set; }
        public double invdisp2 { get; set; }
        public double invdisp3 { get; set; }
        public double discount { get; set; }
        public string trntype { get; set; }
        public int invbill { get; set; }
        public string invpo { get; set; }
        public double invother { get; set; }
        public string descript { get; set; }
        public DateTime startdate { get; set; }
        public string userid { get; set; }
        public bool biclosed { get; set; }
        public double resum { get; set; }
        public double rt_count { get; set; }
        public double rt_sumtt { get; set; }
        public double ex_sumtt { get; set; }
        public double bo_sumtt { get; set; }
        public string option_ { get; set; }
        public string invtrans { get; set; }
        public int item { get; set; }
        public string invref { get; set; }
        public int trans { get; set; }
        public string REMARK { get; set; }
        public string biline { get; set; }
        public bool rdeleted { get; set; }
        public string usrdel { get; set; }
        public DateTime deltime { get; set; }
        public string order_id { get; set; }
        public string invflag { get; set; }
        public string acccode { get; set; }
        public string egroup { get; set; }
        public string travouc { get; set; }
        public string batchno { get; set; }
        public int payref { get; set; }
        public bool isclosed { get; set; }
        public string recvouc { get; set; }
        public string pbranch { get; set; }
        public double RECM { get; set; }
        public double CHANGM { get; set; }
        public string TAXINVW { get; set; }
        public double INVCREDIT { get; set; }
        public double taxamo { get; set; }
        public DateTime taxstamp { get; set; }
        public string PAYBANK { get; set; }
        public int PAYMENT { get; set; }
        public string comno { get; set; }
        public int ckcash { get; set; }
        public double paycash { get; set; }
        public int cktran { get; set; }
        public double paytran { get; set; }
        public int ckcard { get; set; }
        public double paycard { get; set; }
        public int ckoth { get; set; }
        public double perc { get; set; }
        public double charge { get; set; }
        public double payoth { get; set; }
        public DateTime grecdate { get; set; }
        public string grecnum { get; set; }
        public string emlocation { get; set; }
        public DateTime earnestrec { get; set; }
        public string invearnest { get; set; }
        public double resumear { get; set; }
        public string saleinv { get; set; }
        public int usercf { get; set; }
        public string ipaddress { get; set; }
        public string pcname { get; set; }
        public double cardamo { get; set; }
        public string cashierno { get; set; }
        public string taxinvoice { get; set; }
        public string poref { get; set; }
        public double deposit { get; set; }
        public double unpaid { get; set; }
        public double rsinvnet { get; set; }
        public double rsinvvat { get; set; }
        public double rsinvsum { get; set; }
        public double rsbalance { get; set; }
        public DateTime currdate { get; set; }
        public double toppvat { get; set; }
        public string retno { get; set; }
        public double retamo { get; set; }
        public string invcustpo { get; set; }
        public string carregis { get; set; }
        public string pkuser { get; set; }
        public string remarkb { get; set; }
        public string clame { get; set; }
        public string edno { get; set; }
        public string tsno { get; set; }
        public string model { get; set; }
        public string evcode { get; set; }
        public string evname { get; set; }
        public string evadd { get; set; }
        public string evtel { get; set; }
        public string invkline { get; set; }
        public int jobnumb { get; set; }
        public int jobitem { get; set; }
        public string etruck { get; set; }
        public string edriver { get; set; }
        public DateTime cartimeout { get; set; }
        public int jobapproved { get; set; }
        public int rechk_exps { get; set; }
        public int toption { get; set; }
        public int jobConfirm { get; set; }
        public string bodyNo { get; set; }
        public string flagrec { get; set; }
        public string exp_by { get; set; }
        public DateTime exp_datetime { get; set; }
        public DateTime start_invdate { get; set; }
        public DateTime end_invdate { get; set; }
        public string eaddress_full { get; set; }
        public string e_delivery_address { get; set; }
        public string delivery_address { get; set; }
        public string emmas_addres { get; set; }
    }

    public partial class InvfileModel
    {
        public string number { get; set; }
        public DateTime invdate { get; set; }
        public string invcode { get; set; }
        public string invbook { get; set; }
        public int invno { get; set; }
        public string invname { get; set; }
        public int invdue { get; set; }
        public DateTime duedate { get; set; }
        public double invnet { get; set; }
        public double invearnamo { get; set; }
        public double invvat { get; set; }
        public double invsumtt { get; set; }
        public double invgcost { get; set; }
        public double invprofit { get; set; }
        public string invscode { get; set; }
        public double invdisp1 { get; set; }
        public double invdisp2 { get; set; }
        public double invdisp3 { get; set; }
        public double discount { get; set; }
        public string trntype { get; set; }
        public int invbill { get; set; }
        public string invpo { get; set; }
        public double invother { get; set; }
        public string descript { get; set; }
        public DateTime startdate { get; set; }
        public string userid { get; set; }
        public bool biclosed { get; set; }
        public double resum { get; set; }
        public double rt_count { get; set; }
        public double rt_sumtt { get; set; }
        public double ex_sumtt { get; set; }
        public double bo_sumtt { get; set; }
        public string option_ { get; set; }
        public string invtrans { get; set; }
        public int item { get; set; }
        public string invref { get; set; }
        public int trans { get; set; }
        public string REMARK { get; set; }
        public string biline { get; set; }
        public bool rdeleted { get; set; }
        public string usrdel { get; set; }
        public DateTime deltime { get; set; }
        public string order_id { get; set; }
        public string invflag { get; set; }
        public string acccode { get; set; }
        public string egroup { get; set; }
        public string travouc { get; set; }
        public string batchno { get; set; }
        public int payref { get; set; }
        public bool isclosed { get; set; }
        public string recvouc { get; set; }
        public string pbranch { get; set; }
        public double RECM { get; set; }
        public double CHANGM { get; set; }
        public string TAXINVW { get; set; }
        public double INVCREDIT { get; set; }
        public double taxamo { get; set; }
        public DateTime taxstamp { get; set; }
        public string PAYBANK { get; set; }
        public int PAYMENT { get; set; }
        public string comno { get; set; }
        public int ckcash { get; set; }
        public double paycash { get; set; }
        public int cktran { get; set; }
        public double paytran { get; set; }
        public int ckcard { get; set; }
        public double paycard { get; set; }
        public int ckoth { get; set; }
        public double perc { get; set; }
        public double charge { get; set; }
        public double payoth { get; set; }
        public DateTime grecdate { get; set; }
        public string grecnum { get; set; }
        public string emlocation { get; set; }
        public DateTime earnestrec { get; set; }
        public string invearnest { get; set; }
        public double resumear { get; set; }
        public string saleinv { get; set; }
        public int usercf { get; set; }
        public string ipaddress { get; set; }
        public string pcname { get; set; }
        public double cardamo { get; set; }
        public string cashierno { get; set; }
        public string taxinvoice { get; set; }
        public string poref { get; set; }
        public double deposit { get; set; }
        public double unpaid { get; set; }
        public double rsinvnet { get; set; }
        public double rsinvvat { get; set; }
        public double rsinvsum { get; set; }
        public double rsbalance { get; set; }
        public DateTime currdate { get; set; }
        public double toppvat { get; set; }
        public string retno { get; set; }
        public double retamo { get; set; }
        public string invcustpo { get; set; }
        public string carregis { get; set; }
        public string pkuser { get; set; }
        public string remarkb { get; set; }
        public string clame { get; set; }
        public string edno { get; set; }
        public string tsno { get; set; }
        public string model { get; set; }
        public string evcode { get; set; }
        public string evname { get; set; }
        public string evadd { get; set; }
        public string evtel { get; set; }
        public string invkline { get; set; }
        public int jobnumb { get; set; }
        public int jobitem { get; set; }
        public string etruck { get; set; }
        public string edriver { get; set; }
        public DateTime cartimeout { get; set; }
        public int jobapproved { get; set; }
        public int rechk_exps { get; set; }
        public int toption { get; set; }
        public int jobConfirm { get; set; }
        public string bodyNo { get; set; }
        public string flagrec { get; set; }
        public string exp_by { get; set; }
        public DateTime exp_datetime { get; set; }
        public DateTime start_invdate { get; set; }
        public DateTime end_invdate { get; set; }
        public string eaddress_full { get; set; }
        public string e_delivery_address { get; set; }
        public string delivery_address { get; set; }
        public string emmas_addres { get; set; }
    }
}
