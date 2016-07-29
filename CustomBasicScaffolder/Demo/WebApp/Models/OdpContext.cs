namespace WebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OdpContext : DbContext
    {
        public OdpContext()
            : base("name=OdpContext")
        {
        }

        public virtual DbSet<AUTO_CHECKRESULT> AUTO_CHECKRESULT { get; set; }
        public virtual DbSet<AUTO_RECORDINFO> AUTO_RECORDINFO { get; set; }
        public virtual DbSet<AUTO_TABCONFIG> AUTO_TABCONFIG { get; set; }
        public virtual DbSet<AUTO_TEMPLATE> AUTO_TEMPLATE { get; set; }
        public virtual DbSet<BASE_ALTERRECORD> BASE_ALTERRECORD { get; set; }
        public virtual DbSet<BASE_ASSISTKIND> BASE_ASSISTKIND { get; set; }
        public virtual DbSet<BASE_CIQCODE> BASE_CIQCODE { get; set; }
        public virtual DbSet<BASE_COMMODITYHS> BASE_COMMODITYHS { get; set; }
        public virtual DbSet<BASE_COMPANY> BASE_COMPANY { get; set; }
        public virtual DbSet<BASE_CONSIGNEETYPE> BASE_CONSIGNEETYPE { get; set; }
        public virtual DbSet<BASE_CONTAINERSIZE> BASE_CONTAINERSIZE { get; set; }
        public virtual DbSet<BASE_CONTAINERSTANDARD> BASE_CONTAINERSTANDARD { get; set; }
        public virtual DbSet<BASE_CONTAINERTYPE> BASE_CONTAINERTYPE { get; set; }
        public virtual DbSet<BASE_COUNTRY> BASE_COUNTRY { get; set; }
        public virtual DbSet<BASE_CUSTOMDISTRICT> BASE_CUSTOMDISTRICT { get; set; }
        public virtual DbSet<BASE_DECLCURRENCY> BASE_DECLCURRENCY { get; set; }
        public virtual DbSet<BASE_DECLFEE> BASE_DECLFEE { get; set; }
        public virtual DbSet<BASE_DECLHSCHAPTER> BASE_DECLHSCHAPTER { get; set; }
        public virtual DbSet<BASE_DECLHSTYPE> BASE_DECLHSTYPE { get; set; }
        public virtual DbSet<BASE_DECLPRODUCTUNIT> BASE_DECLPRODUCTUNIT { get; set; }
        public virtual DbSet<BASE_DECLSTATUS> BASE_DECLSTATUS { get; set; }
        public virtual DbSet<BASE_DECLTRADEWAY> BASE_DECLTRADEWAY { get; set; }
        public virtual DbSet<BASE_DECLUSE> BASE_DECLUSE { get; set; }
        public virtual DbSet<BASE_EXCHANGEWAY> BASE_EXCHANGEWAY { get; set; }
        public virtual DbSet<BASE_HARBOUR> BASE_HARBOUR { get; set; }
        public virtual DbSet<BASE_INSPCOMPANYNATURE> BASE_INSPCOMPANYNATURE { get; set; }
        public virtual DbSet<BASE_INSPCONVEYANCE> BASE_INSPCONVEYANCE { get; set; }
        public virtual DbSet<BASE_INSPECTFLAG> BASE_INSPECTFLAG { get; set; }
        public virtual DbSet<BASE_INSPECTIONAGENCY> BASE_INSPECTIONAGENCY { get; set; }
        public virtual DbSet<BASE_INSPHS> BASE_INSPHS { get; set; }
        public virtual DbSet<BASE_INSPINVOICE> BASE_INSPINVOICE { get; set; }
        public virtual DbSet<BASE_INSPLICENSE> BASE_INSPLICENSE { get; set; }
        public virtual DbSet<BASE_INSPUSE> BASE_INSPUSE { get; set; }
        public virtual DbSet<BASE_LISTTYPE> BASE_LISTTYPE { get; set; }
        public virtual DbSet<BASE_MOTORCADE> BASE_MOTORCADE { get; set; }
        public virtual DbSet<BASE_NEEDDOCUMENT> BASE_NEEDDOCUMENT { get; set; }
        public virtual DbSet<BASE_ORDERSTATUS> BASE_ORDERSTATUS { get; set; }
        public virtual DbSet<BASE_PORT> BASE_PORT { get; set; }
        public virtual DbSet<BASE_REPORTREGION> BASE_REPORTREGION { get; set; }
        public virtual DbSet<BASE_SPECIALHSCONVERT> BASE_SPECIALHSCONVERT { get; set; }
        public virtual DbSet<BASE_STATUSCONFIG> BASE_STATUSCONFIG { get; set; }
        public virtual DbSet<BASE_TRADEWAY> BASE_TRADEWAY { get; set; }
        public virtual DbSet<BASE_TRANSACTION> BASE_TRANSACTION { get; set; }
        public virtual DbSet<BASE_WASTEGOODS> BASE_WASTEGOODS { get; set; }
        public virtual DbSet<BASE_WITHINREGION> BASE_WITHINREGION { get; set; }
        public virtual DbSet<BASE_YEAR> BASE_YEAR { get; set; }
        public virtual DbSet<CHATMESSAGE> CHATMESSAGEs { get; set; }
        public virtual DbSet<CHATTOPIC> CHATTOPICs { get; set; }
        public virtual DbSet<CODESMITH_EXTENDED_PROPERTIES> CODESMITH_EXTENDED_PROPERTIES { get; set; }
        public virtual DbSet<CONFIG_ALTERRECORD> CONFIG_ALTERRECORD { get; set; }
        public virtual DbSet<CONFIG_CONSUMING> CONFIG_CONSUMING { get; set; }
        public virtual DbSet<CONFIG_NOTICE> CONFIG_NOTICE { get; set; }
        public virtual DbSet<CONFIG_PAGECONFIG> CONFIG_PAGECONFIG { get; set; }
        public virtual DbSet<CONFIG_PAGECONFIGDETAIL> CONFIG_PAGECONFIGDETAIL { get; set; }
        public virtual DbSet<CONFIG_PGCUSTOMSMAPPING> CONFIG_PGCUSTOMSMAPPING { get; set; }
        public virtual DbSet<CONFIG_PGFROMMAPPING> CONFIG_PGFROMMAPPING { get; set; }
        public virtual DbSet<CONFIG_PGTABLEMAPPING> CONFIG_PGTABLEMAPPING { get; set; }
        public virtual DbSet<CONFIG_PREORDER> CONFIG_PREORDER { get; set; }
        public virtual DbSet<CONFIG_PROXYER> CONFIG_PROXYER { get; set; }
        public virtual DbSet<CONFIG_SETPARAMETER> CONFIG_SETPARAMETER { get; set; }
        public virtual DbSet<CONFIG_SPECIALRULES> CONFIG_SPECIALRULES { get; set; }
        public virtual DbSet<CONFIG_WARNING> CONFIG_WARNING { get; set; }
        public virtual DbSet<CONTAINER> CONTAINERS { get; set; }
        public virtual DbSet<DEP> DEPs { get; set; }
        public virtual DbSet<DOCINFO> DOCINFOS { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public virtual DbSet<FIN_ACCOUNTSRECEIVABLE> FIN_ACCOUNTSRECEIVABLE { get; set; }
        public virtual DbSet<FIN_COSTSETTLEMENTRULE_D> FIN_COSTSETTLEMENTRULE_D { get; set; }
        public virtual DbSet<FIN_COSTSETTLEMENTRULE_H> FIN_COSTSETTLEMENTRULE_H { get; set; }
        public virtual DbSet<FIN_COSTUNIT> FIN_COSTUNIT { get; set; }
        public virtual DbSet<FIN_RECEIVABLERULES_D> FIN_RECEIVABLERULES_D { get; set; }
        public virtual DbSet<FIN_RECEIVABLERULES_H> FIN_RECEIVABLERULES_H { get; set; }
        public virtual DbSet<FIN_RECEIVABLERULESCUS_D> FIN_RECEIVABLERULESCUS_D { get; set; }
        public virtual DbSet<FIN_RECEIVABLERULESCUS_H> FIN_RECEIVABLERULESCUS_H { get; set; }
        public virtual DbSet<FINANCE_APPROVALRECORD> FINANCE_APPROVALRECORD { get; set; }
        public virtual DbSet<FINANCE_BUDGETTYPE> FINANCE_BUDGETTYPE { get; set; }
        public virtual DbSet<FINANCE_COST> FINANCE_COST { get; set; }
        public virtual DbSet<FINANCE_EXPENDITURE> FINANCE_EXPENDITURE { get; set; }
        public virtual DbSet<FINANCE_EXPENSEPAYABLE> FINANCE_EXPENSEPAYABLE { get; set; }
        public virtual DbSet<LIST_ATTACHMENT> LIST_ATTACHMENT { get; set; }
        public virtual DbSet<LIST_ATTACHMENTDETAIL> LIST_ATTACHMENTDETAIL { get; set; }
        public virtual DbSet<LIST_CHECKORDERMARK> LIST_CHECKORDERMARK { get; set; }
        public virtual DbSet<LIST_CSPOND> LIST_CSPOND { get; set; }
        public virtual DbSet<LIST_DECLARATION> LIST_DECLARATION { get; set; }
        public virtual DbSet<LIST_DECLARATION_AFTER> LIST_DECLARATION_AFTER { get; set; }
        public virtual DbSet<LIST_ELEBACK> LIST_ELEBACK { get; set; }
        public virtual DbSet<LIST_FILECONFIG> LIST_FILECONFIG { get; set; }
        public virtual DbSet<LIST_INSPECTION> LIST_INSPECTION { get; set; }
        public virtual DbSet<LIST_INSPECTION_AFTER> LIST_INSPECTION_AFTER { get; set; }
        public virtual DbSet<LIST_INVENTORYHISTORY> LIST_INVENTORYHISTORY { get; set; }
        public virtual DbSet<LIST_ISBACK> LIST_ISBACK { get; set; }
        public virtual DbSet<LIST_LICENSE> LIST_LICENSE { get; set; }
        public virtual DbSet<LIST_ORDER> LIST_ORDER { get; set; }
        public virtual DbSet<LIST_ORDERATTACHMENT> LIST_ORDERATTACHMENT { get; set; }
        public virtual DbSet<LIST_ORDERRECORDER> LIST_ORDERRECORDER { get; set; }
        public virtual DbSet<LIST_PAUSE> LIST_PAUSE { get; set; }
        public virtual DbSet<LIST_PAUSEOK> LIST_PAUSEOK { get; set; }
        public virtual DbSet<LIST_PREDECLACCDOC> LIST_PREDECLACCDOC { get; set; }
        public virtual DbSet<LIST_PREDECLACCDOC_AFTER> LIST_PREDECLACCDOC_AFTER { get; set; }
        public virtual DbSet<LIST_PREDECLARATION> LIST_PREDECLARATION { get; set; }
        public virtual DbSet<LIST_PREDECLCONTAINER> LIST_PREDECLCONTAINER { get; set; }
        public virtual DbSet<LIST_PREDECLCONTAINER_AFTER> LIST_PREDECLCONTAINER_AFTER { get; set; }
        public virtual DbSet<LIST_PREDECLLIST> LIST_PREDECLLIST { get; set; }
        public virtual DbSet<LIST_PREDECLLIST_AFTER> LIST_PREDECLLIST_AFTER { get; set; }
        public virtual DbSet<LIST_PREINSPCONTAINER> LIST_PREINSPCONTAINER { get; set; }
        public virtual DbSet<LIST_PREINSPECTION> LIST_PREINSPECTION { get; set; }
        public virtual DbSet<LIST_PREINSPLIST> LIST_PREINSPLIST { get; set; }
        public virtual DbSet<LIST_PREINSPLIST_AFTER> LIST_PREINSPLIST_AFTER { get; set; }
        public virtual DbSet<LIST_PRETCCGMAPPING> LIST_PRETCCGMAPPING { get; set; }
        public virtual DbSet<LIST_PRETCCONTAINER> LIST_PRETCCONTAINER { get; set; }
        public virtual DbSet<LIST_PRETRANCUSTOMS> LIST_PRETRANCUSTOMS { get; set; }
        public virtual DbSet<LIST_PRETRANCUSTOMS_AFTER> LIST_PRETRANCUSTOMS_AFTER { get; set; }
        public virtual DbSet<LIST_RECEIPTSTATUS> LIST_RECEIPTSTATUS { get; set; }
        public virtual DbSet<LIST_RESENDHISTORY> LIST_RESENDHISTORY { get; set; }
        public virtual DbSet<LIST_SUBSCRIBE> LIST_SUBSCRIBE { get; set; }
        public virtual DbSet<LIST_TIMES> LIST_TIMES { get; set; }
        public virtual DbSet<LOADDATA> LOADDATAs { get; set; }
        public virtual DbSet<PDFSHRINKLOG> PDFSHRINKLOGs { get; set; }
        public virtual DbSet<RELA_COMPANYNATURE> RELA_COMPANYNATURE { get; set; }
        public virtual DbSet<RELA_CONTAINER> RELA_CONTAINER { get; set; }
        public virtual DbSet<RELA_COUNTRY> RELA_COUNTRY { get; set; }
        public virtual DbSet<RELA_CURRENCY> RELA_CURRENCY { get; set; }
        public virtual DbSet<RELA_PACKAGE> RELA_PACKAGE { get; set; }
        public virtual DbSet<RELA_PORT> RELA_PORT { get; set; }
        public virtual DbSet<RELA_PRODUCTUNIT> RELA_PRODUCTUNIT { get; set; }
        public virtual DbSet<RELA_TRADE> RELA_TRADE { get; set; }
        public virtual DbSet<RELA_TRANSPORT> RELA_TRANSPORT { get; set; }
        public virtual DbSet<RELA_WITHINREGION> RELA_WITHINREGION { get; set; }
        public virtual DbSet<SUBDATA> SUBDATAs { get; set; }
        public virtual DbSet<SYS_BUSIKIND> SYS_BUSIKIND { get; set; }
        public virtual DbSet<SYS_BUSITYPE> SYS_BUSITYPE { get; set; }
        public virtual DbSet<SYS_CODE> SYS_CODE { get; set; }
        public virtual DbSet<SYS_COMPANY> SYS_COMPANY { get; set; }
        public virtual DbSet<SYS_CUSTOMER> SYS_CUSTOMER { get; set; }
        public virtual DbSet<SYS_DECLARATIONCAR> SYS_DECLARATIONCAR { get; set; }
        public virtual DbSet<SYS_DECLWAY> SYS_DECLWAY { get; set; }
        public virtual DbSet<SYS_DEPARTMENT> SYS_DEPARTMENT { get; set; }
        public virtual DbSet<SYS_ENTRUSTTYPE> SYS_ENTRUSTTYPE { get; set; }
        public virtual DbSet<SYS_FTPSETTINGS> SYS_FTPSETTINGS { get; set; }
        public virtual DbSet<SYS_GOODSTYPE> SYS_GOODSTYPE { get; set; }
        public virtual DbSet<SYS_INSPLIBRARY> SYS_INSPLIBRARY { get; set; }
        public virtual DbSet<SYS_INSPTYPE> SYS_INSPTYPE { get; set; }
        public virtual DbSet<SYS_MACADDRESS> SYS_MACADDRESS { get; set; }
        public virtual DbSet<SYS_NOTICETYPE> SYS_NOTICETYPE { get; set; }
        public virtual DbSet<SYS_POSITION> SYS_POSITION { get; set; }
        public virtual DbSet<SYS_PROCEDUREMAPPING> SYS_PROCEDUREMAPPING { get; set; }
        public virtual DbSet<SYS_RECORDINFO> SYS_RECORDINFO { get; set; }
        public virtual DbSet<SYS_RECORDINFO_DETAIL> SYS_RECORDINFO_DETAIL { get; set; }
        public virtual DbSet<SYS_REGUAREATYPE> SYS_REGUAREATYPE { get; set; }
        public virtual DbSet<SYS_REPORTLIBRARY> SYS_REPORTLIBRARY { get; set; }
        public virtual DbSet<SYS_REPWAY> SYS_REPWAY { get; set; }
        public virtual DbSet<SYS_STATUS> SYS_STATUS { get; set; }
        public virtual DbSet<SYS_TRMAPPING> SYS_TRMAPPING { get; set; }
        public virtual DbSet<SYS_UNITCONVERT> SYS_UNITCONVERT { get; set; }
        public virtual DbSet<SYS_USER> SYS_USER { get; set; }
        public virtual DbSet<SYS_WOODPACKING> SYS_WOODPACKING { get; set; }
        public virtual DbSet<SYSAPPLICATION> SYSAPPLICATIONs { get; set; }
        public virtual DbSet<SYSAUTH> SYSAUTHs { get; set; }
        public virtual DbSet<SYSAUTHTYPE> SYSAUTHTYPEs { get; set; }
        public virtual DbSet<SYSENUMERATION> SYSENUMERATIONs { get; set; }
        public virtual DbSet<SYSEVENTCONFIG> SYSEVENTCONFIGs { get; set; }
        public virtual DbSet<SYSEVENTLOG> SYSEVENTLOGs { get; set; }
        public virtual DbSet<SYSEVENTTYPE> SYSEVENTTYPEs { get; set; }
        public virtual DbSet<SYSGROUP> SYSGROUPs { get; set; }
        public virtual DbSet<SYSMODULE> SYSMODULEs { get; set; }
        public virtual DbSet<SYSMODULETYPE> SYSMODULETYPEs { get; set; }
        public virtual DbSet<SYSMSGSENDED> SYSMSGSENDEDs { get; set; }
        public virtual DbSet<SYSMSGTOSEND> SYSMSGTOSENDs { get; set; }
        public virtual DbSet<SYSROLE> SYSROLEs { get; set; }
        public virtual DbSet<SYSROLETYPE> SYSROLETYPEs { get; set; }
        public virtual DbSet<SYSSYSTEM> SYSSYSTEMs { get; set; }
        public virtual DbSet<SYSTASK> SYSTASKs { get; set; }
        public virtual DbSet<T_DZ> T_DZ { get; set; }
        public virtual DbSet<T_JZX> T_JZX { get; set; }
        public virtual DbSet<T_MENU> T_MENU { get; set; }
        public virtual DbSet<T_ROLE> T_ROLE { get; set; }
        public virtual DbSet<T_ROLEMENU> T_ROLEMENU { get; set; }
        public virtual DbSet<T_USERROLE> T_USERROLE { get; set; }
        public virtual DbSet<T_ZGFY> T_ZGFY { get; set; }
        public virtual DbSet<TASK_28BACKFILL> TASK_28BACKFILL { get; set; }
        public virtual DbSet<TASK_DECLWRITE> TASK_DECLWRITE { get; set; }
        public virtual DbSet<TASK_INSPHISTORY> TASK_INSPHISTORY { get; set; }
        public virtual DbSet<TASK_INSPWRITE> TASK_INSPWRITE { get; set; }
        public virtual DbSet<TASK_ZGD> TASK_ZGD { get; set; }
        public virtual DbSet<USER_RENAME_COMPANY> USER_RENAME_COMPANY { get; set; }
        public virtual DbSet<USER_USE_DECLARATIONCAR> USER_USE_DECLARATIONCAR { get; set; }
        public virtual DbSet<YWTOTAL> YWTOTALs { get; set; }
        public virtual DbSet<BGDZT> BGDZTs { get; set; }
        public virtual DbSet<BGJ_LOADDATA> BGJ_LOADDATA { get; set; }
        public virtual DbSet<BGJ_SUBDATA> BGJ_SUBDATA { get; set; }
        public virtual DbSet<CHATTOPICRECEIVER> CHATTOPICRECEIVERs { get; set; }
        public virtual DbSet<FIN_CONFIGURE> FIN_CONFIGURE { get; set; }
        public virtual DbSet<LIST_INSPRECEIPTSTATUS> LIST_INSPRECEIPTSTATUS { get; set; }
        public virtual DbSet<LIST_UPDATEHISTORY> LIST_UPDATEHISTORY { get; set; }
        public virtual DbSet<SC_SUBDATA> SC_SUBDATA { get; set; }
        public virtual DbSet<SYS_FILETYPE> SYS_FILETYPE { get; set; }
        public virtual DbSet<SYSGROUPPERMISSION> SYSGROUPPERMISSIONs { get; set; }
        public virtual DbSet<SYSGROUPROLE> SYSGROUPROLEs { get; set; }
        public virtual DbSet<SYSROLEPERMISSION> SYSROLEPERMISSIONs { get; set; }
        public virtual DbSet<SYSTEMSET> SYSTEMSETs { get; set; }
        public virtual DbSet<SYSUSERGROUP> SYSUSERGROUPs { get; set; }
        public virtual DbSet<SYSUSERPERMISSION> SYSUSERPERMISSIONs { get; set; }
        public virtual DbSet<SYSUSERROLE> SYSUSERROLEs { get; set; }
        public virtual DbSet<T_CPINFO> T_CPINFO { get; set; }
        public virtual DbSet<TASK_INSPWRITEMAPPING> TASK_INSPWRITEMAPPING { get; set; }
        public virtual DbSet<TASK_ZC> TASK_ZC { get; set; }
        public virtual DbSet<TASK_ZT> TASK_ZT { get; set; }
        public virtual DbSet<WEB_BANNER> WEB_BANNER { get; set; }
        public virtual DbSet<WEB_NOTICE> WEB_NOTICE { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<AUTO_CHECKRESULT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<AUTO_RECORDINFO>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<AUTO_RECORDINFO>()
        //        .Property(e => e.NUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<AUTO_RECORDINFO>()
        //        .Property(e => e.TEMPLATEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<AUTO_RECORDINFO>()
        //        .Property(e => e.ACTION)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<AUTO_RECORDINFO>()
        //        .Property(e => e.CYCLEFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<AUTO_RECORDINFO>()
        //        .Property(e => e.INTERVAL)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<AUTO_RECORDINFO>()
        //        .Property(e => e.MOUSEACTION)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<AUTO_TABCONFIG>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<AUTO_TABCONFIG>()
        //        .Property(e => e.ORDERNO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<AUTO_TEMPLATE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<AUTO_TEMPLATE>()
        //        .Property(e => e.MAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ALTERRECORD>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ALTERRECORD>()
        //        .Property(e => e.TABID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ALTERRECORD>()
        //        .Property(e => e.TABKIND)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ALTERRECORD>()
        //        .Property(e => e.ALTERMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ASSISTKIND>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ASSISTKIND>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ASSISTKIND>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ASSISTKIND>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CIQCODE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CIQCODE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CIQCODE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CIQCODE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CIQCODE>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COMMODITYHS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COMMODITYHS>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COMMODITYHS>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COMMODITYHS>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COMMODITYHS>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COMPANY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COMPANY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COMPANY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COMPANY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONSIGNEETYPE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONSIGNEETYPE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONSIGNEETYPE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONSIGNEETYPE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERSIZE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERSIZE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERSIZE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERSIZE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERSTANDARD>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERSTANDARD>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERSTANDARD>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERSTANDARD>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERTYPE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERTYPE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERTYPE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CONTAINERTYPE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COUNTRY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COUNTRY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COUNTRY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COUNTRY>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_COUNTRY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CUSTOMDISTRICT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CUSTOMDISTRICT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CUSTOMDISTRICT>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CUSTOMDISTRICT>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_CUSTOMDISTRICT>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLCURRENCY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLCURRENCY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLCURRENCY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLCURRENCY>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLCURRENCY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLFEE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLFEE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLFEE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLFEE>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLFEE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLHSCHAPTER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLHSCHAPTER>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLHSTYPE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLHSTYPE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLPRODUCTUNIT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLPRODUCTUNIT>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLPRODUCTUNIT>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLPRODUCTUNIT>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLPRODUCTUNIT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLSTATUS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLSTATUS>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLSTATUS>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLSTATUS>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLSTATUS>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLTRADEWAY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLTRADEWAY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLTRADEWAY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLTRADEWAY>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLTRADEWAY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLUSE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLUSE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLUSE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLUSE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_DECLUSE>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_EXCHANGEWAY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_EXCHANGEWAY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_EXCHANGEWAY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_EXCHANGEWAY>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_EXCHANGEWAY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_HARBOUR>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_HARBOUR>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_HARBOUR>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_HARBOUR>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_HARBOUR>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPCOMPANYNATURE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPCOMPANYNATURE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPCOMPANYNATURE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPCOMPANYNATURE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPCONVEYANCE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPCONVEYANCE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPCONVEYANCE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPCONVEYANCE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPCONVEYANCE>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPECTFLAG>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPECTFLAG>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPECTFLAG>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPECTFLAG>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPECTIONAGENCY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPECTIONAGENCY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPECTIONAGENCY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPECTIONAGENCY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPECTIONAGENCY>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPHS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPHS>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPHS>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPHS>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPHS>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPINVOICE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPINVOICE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPINVOICE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPINVOICE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPINVOICE>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPLICENSE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPLICENSE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPLICENSE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPLICENSE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPLICENSE>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPUSE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPUSE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPUSE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPUSE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_INSPUSE>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_LISTTYPE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_LISTTYPE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_LISTTYPE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_LISTTYPE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_MOTORCADE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_MOTORCADE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_MOTORCADE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_MOTORCADE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_NEEDDOCUMENT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_NEEDDOCUMENT>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_NEEDDOCUMENT>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_NEEDDOCUMENT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_NEEDDOCUMENT>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ORDERSTATUS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ORDERSTATUS>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ORDERSTATUS>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ORDERSTATUS>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_ORDERSTATUS>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_PORT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_PORT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_PORT>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_PORT>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_PORT>()
        //        .Property(e => e.IN_OUT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_PORT>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_REPORTREGION>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_REPORTREGION>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_REPORTREGION>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_REPORTREGION>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_REPORTREGION>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_SPECIALHSCONVERT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_SPECIALHSCONVERT>()
        //        .Property(e => e.CONVERTRATE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_SPECIALHSCONVERT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_SPECIALHSCONVERT>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_SPECIALHSCONVERT>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_STATUSCONFIG>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_STATUSCONFIG>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_STATUSCONFIG>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_STATUSCONFIG>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_STATUSCONFIG>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_STATUSCONFIG>()
        //        .Property(e => e.ORDERNO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_TRADEWAY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_TRADEWAY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_TRADEWAY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_TRADEWAY>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_TRADEWAY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_TRANSACTION>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_TRANSACTION>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BASE_TRANSACTION>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BASE_TRANSACTION>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_TRANSACTION>()
        //        .Property(e => e.REMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BASE_TRANSACTION>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_TRANSACTION>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_TRANSACTION>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_WASTEGOODS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_WASTEGOODS>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_WASTEGOODS>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_WASTEGOODS>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_WASTEGOODS>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_WITHINREGION>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_WITHINREGION>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_WITHINREGION>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_WITHINREGION>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_WITHINREGION>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_YEAR>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_YEAR>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BASE_YEAR>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_YEAR>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_YEAR>()
        //        .Property(e => e.REMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BASE_YEAR>()
        //        .Property(e => e.KIND)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BASE_YEAR>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.CHATTOPICID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.SENDUSER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.RECEVERUSER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.ISREAD)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.OffLine)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.ISFILE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.FILENAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.FILEPATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.RECFILEPATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.CREATEUSER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.EDITUSER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.MESSAGE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.SAMEGUID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.GIFSMSG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATMESSAGE>()
        //        .Property(e => e.SERVERFILEPATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATTOPIC>()
        //        .Property(e => e.ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATTOPIC>()
        //        .Property(e => e.ORDERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CHATTOPIC>()
        //        .Property(e => e.ISCLOSE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATTOPIC>()
        //        .Property(e => e.CREATEUSER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CHATTOPIC>()
        //        .Property(e => e.EDITUSER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CHATTOPIC>()
        //        .Property(e => e.CHATTOPICMSG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CODESMITH_EXTENDED_PROPERTIES>()
        //        .Property(e => e.CONTAINER_OBJECT_OWNER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CODESMITH_EXTENDED_PROPERTIES>()
        //        .Property(e => e.OBJECT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CODESMITH_EXTENDED_PROPERTIES>()
        //        .Property(e => e.CODESMITH_SCHEMA_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CODESMITH_EXTENDED_PROPERTIES>()
        //        .Property(e => e.PROPERTY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CODESMITH_EXTENDED_PROPERTIES>()
        //        .Property(e => e.PROPERTY_VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CODESMITH_EXTENDED_PROPERTIES>()
        //        .Property(e => e.CLR_TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONFIG_ALTERRECORD>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_ALTERRECORD>()
        //        .Property(e => e.ALTERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_CONSUMING>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_CONSUMING>()
        //        .Property(e => e.POST)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_CONSUMING>()
        //        .Property(e => e.AREA)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_CONSUMING>()
        //        .Property(e => e.DATETYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_CONSUMING>()
        //        .Property(e => e.MAINTAIN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_CONSUMING>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_NOTICE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_NOTICE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_NOTICE>()
        //        .Property(e => e.DATETYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_NOTICE>()
        //        .Property(e => e.DATENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_NOTICE>()
        //        .Property(e => e.FREQUENCY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_NOTICE>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIG>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIG>()
        //        .Property(e => e.PCTYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIG>()
        //        .Property(e => e.PAGETYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIG>()
        //        .Property(e => e.ENABLE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIG>()
        //        .Property(e => e.CONFIGBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIG>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIG>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIG>()
        //        .Property(e => e.WARNING)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIG>()
        //        .Property(e => e.PAGEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIGDETAIL>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIGDETAIL>()
        //        .Property(e => e.PAGECONFIGID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIGDETAIL>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIGDETAIL>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PAGECONFIGDETAIL>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PGCUSTOMSMAPPING>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PGCUSTOMSMAPPING>()
        //        .Property(e => e.PAGECONFIGID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PGCUSTOMSMAPPING>()
        //        .Property(e => e.CUSTOMSID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PGCUSTOMSMAPPING>()
        //        .Property(e => e.CUSTOMSCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CONFIG_PGFROMMAPPING>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PGFROMMAPPING>()
        //        .Property(e => e.PAGECONFIGID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PGFROMMAPPING>()
        //        .Property(e => e.PAGEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PGTABLEMAPPING>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PREORDER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PREORDER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PREORDER>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PREORDER>()
        //        .Property(e => e.PRETYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PREORDER>()
        //        .Property(e => e.AREAID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PROXYER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PROXYER>()
        //        .Property(e => e.PREMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_PROXYER>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_SETPARAMETER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_SETPARAMETER>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_SETPARAMETER>()
        //        .Property(e => e.NUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_SPECIALRULES>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_SPECIALRULES>()
        //        .Property(e => e.HEADBODY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_SPECIALRULES>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_SPECIALRULES>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_SPECIALRULES>()
        //        .Property(e => e.ALTERMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_WARNING>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_WARNING>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_WARNING>()
        //        .Property(e => e.ALTERMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_WARNING>()
        //        .Property(e => e.ENABLEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONFIG_WARNING>()
        //        .Property(e => e.CONDITION5)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CONTAINER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<DEP>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<DOCINFO>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.E_ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.E_DEP)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<EMPLOYEE>()
        //        .Property(e => e.E_ISSUP)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.COSTCATEGORYID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.COSTNAMEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.SETTLEMENTUNITID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.CHARGEQUANTITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.UNITPRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.TOTAL)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.CURRENCYID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.TAXPRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.TAXRATE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.AMOUNTCREDITED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.OUTPUTTAX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.INVOICEAMOUNT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.FIRSTINSTANCENUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.SECONDINSTANCENUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.CHECKNUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.ISSUENUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.INVOICENUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.FIRSTINSTANCEMARK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.SECONDINSTANCEMARK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.SIGNRECONCILIATION)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.BILLRELEASE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.BILLINGSIGN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.WRITEOFFMARK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.ORDERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.BILLINGFEENAMEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.AUDITSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.INVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_ACCOUNTSRECEIVABLE>()
        //        .Property(e => e.ISAUTOINSERT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.SEQ)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.SERVICEITEMSID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.COSTNAMEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.SUPPLIERNAMEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.RULEEXECUTIONFIELDID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.ENABLEFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.AUDITPERSONID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.DISABLEPERSONID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.COSTSETTLEMENTID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.CALCULATIONCONDITIONID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.CALCULATIONFORMULAID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.UNITPRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.CURRENCYID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.MIN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.MAX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.EXECUTIONFIELDID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.QYJZ)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.RATE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_D>()
        //        .Property(e => e.RULEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_H>()
        //        .Property(e => e.RULEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_H>()
        //        .Property(e => e.COMPANYID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_H>()
        //        .Property(e => e.CREATEMANID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTSETTLEMENTRULE_H>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTUNIT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTUNIT>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_COSTUNIT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTUNIT>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_COSTUNIT>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_D>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_D>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_D>()
        //        .Property(e => e.MAXVALUES)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_D>()
        //        .Property(e => e.MINVALUES)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_D>()
        //        .Property(e => e.RATE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_D>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_D>()
        //        .Property(e => e.PARENTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_D>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_D>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_H>()
        //        .Property(e => e.CREATEUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_H>()
        //        .Property(e => e.CHECKUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_H>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULES_H>()
        //        .Property(e => e.STOPUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_D>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_D>()
        //        .Property(e => e.PARENTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_D>()
        //        .Property(e => e.PRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_D>()
        //        .Property(e => e.MAXVALUES)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_D>()
        //        .Property(e => e.MINVALUES)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_D>()
        //        .Property(e => e.RATE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_D>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_D>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_D>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_D>()
        //        .Property(e => e.PRICEPARA)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_D>()
        //        .Property(e => e.PRICEVAL)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_H>()
        //        .Property(e => e.PCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_H>()
        //        .Property(e => e.CREATEUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_H>()
        //        .Property(e => e.CHECKUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_H>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_RECEIVABLERULESCUS_H>()
        //        .Property(e => e.STOPUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_APPROVALRECORD>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_APPROVALRECORD>()
        //        .Property(e => e.ORDERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_APPROVALRECORD>()
        //        .Property(e => e.COSTNAMEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_APPROVALRECORD>()
        //        .Property(e => e.ALTERMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_APPROVALRECORD>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_APPROVALRECORD>()
        //        .Property(e => e.FIRSTMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_APPROVALRECORD>()
        //        .Property(e => e.SECONDMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_APPROVALRECORD>()
        //        .Property(e => e.REVOKEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_APPROVALRECORD>()
        //        .Property(e => e.APPLICANT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_BUDGETTYPE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_BUDGETTYPE>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_BUDGETTYPE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_BUDGETTYPE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_BUDGETTYPE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_COST>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_COST>()
        //        .Property(e => e.ORDERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_COST>()
        //        .Property(e => e.SETTLEMENTRULESID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_COST>()
        //        .Property(e => e.SUPPLIERNAMEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_COST>()
        //        .Property(e => e.COSTNAMEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_COST>()
        //        .Property(e => e.COST)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_COST>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_COST>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_EXPENDITURE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_EXPENDITURE>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_EXPENDITURE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_EXPENDITURE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_EXPENDITURE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.COMMISSIONNUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.DELEGATEMETHODID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.DELEGATETYPEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.COSTNUMBER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.WEIGHT)
        //        .HasPrecision(12, 2);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.INVOICENUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.BILLLADING)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.DECLARATIONNUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.INSPECTIONNUMBER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.COSTSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.COPINGUNITID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.FJBZ)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FINANCE_EXPENSEPAYABLE>()
        //        .Property(e => e.ML)
        //        .HasPrecision(12, 2);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.UPLOADUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.FILETYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.SIZES)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.CONFIRMSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.CONFIRMER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.ABOLISHSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.ABOLISHER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.ORIGINALFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.SPLITSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.PGINDEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.ORDERCOUNT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENTDETAIL>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENTDETAIL>()
        //        .Property(e => e.ATTACHMENTID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENTDETAIL>()
        //        .Property(e => e.FILETYPEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ATTACHMENTDETAIL>()
        //        .Property(e => e.SPLITEUSER)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ATTACHMENTDETAIL>()
        //        .Property(e => e.ISREP)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_CHECKORDERMARK>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_CHECKORDERMARK>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_CSPOND>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_CSPOND>()
        //        .Property(e => e.PRIORITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_CSPOND>()
        //        .Property(e => e.ISBACK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_CSPOND>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_CSPOND>()
        //        .Property(e => e.BUSITYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_CSPOND>()
        //        .Property(e => e.INVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_CSPOND>()
        //        .Property(e => e.EXTRASTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.GOODSNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.GOODSGW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.GOODSNW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.COTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.ISPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.ISFORCELAW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.ISCOMFORCELAW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.DOWNLOADSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.VALIDATESTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PREACCEPTUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.REPUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.REPFINISHUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PRIORITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PRETIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PREID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.NUMS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PAUSENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.ISBACK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.DECLCHANNEL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.ELEBACK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.CKACCEPTUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.CKISACCEPT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PREDECLFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.DECLPDFFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PREPAUSENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PREISPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.EXTRASTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.CKID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.RESENDNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.SHEETNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.ISPRINT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PRINTNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.ISNEEDCLEARANCE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.ISHAVECLEARANCE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.RELATEDUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.COSUBMITUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.COID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PRINTUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.SPECIALRELATIONSHIP)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PRICEIMPACT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PAYPOYALTIES)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION>()
        //        .Property(e => e.PRESHEETNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.GOODSNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.GOODSGW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.GOODSNW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.COTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.ISFORCELAW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.ISCOMFORCELAW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.DOWNLOADSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.VALIDATESTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.PREACCEPTUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.REPUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.REPFINISHUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.DECLSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.DECLARANT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.CSID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.MOID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.COID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.CLEARANCETYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.MOTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.CSTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.PAGENO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.BACKSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.SPECIALRELATIONSHIP)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.PRICEIMPACT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_DECLARATION_AFTER>()
        //        .Property(e => e.PAYPOYALTIES)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ELEBACK>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ELEBACK>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_FILECONFIG>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_FILECONFIG>()
        //        .Property(e => e.FILETYPEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_FILECONFIG>()
        //        .Property(e => e.FILENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_FILECONFIG>()
        //        .Property(e => e.CREATEUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_FILECONFIG>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_FILECONFIG>()
        //        .Property(e => e.UPFILENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.GOODSNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.GOODSGW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.GOODSNW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.COTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.ISPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.ISFORCELAW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.ISCOMFORCELAW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.DOWNLOADSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.VALIDATESTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.PREACCEPTUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.REPUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.REPFINISHUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.PRIORITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.PRETIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.NUMS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.PAUSENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.PREID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.ISBACK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.PREPAUSENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.PREISPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.EXTRASTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.RESENDNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.ISNEEDCLEARANCE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.ISHAVECLEARANCE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.ISPRINT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.PRINTNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.PREINSPFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.INSPPDFFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.ELEBACK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.RELATEDUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.CKACCEPTUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.CKISACCEPT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.CKID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.COSUBMITUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.COID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION>()
        //        .Property(e => e.PRINTUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.GOODSNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.GOODSGW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.GOODSNW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.COTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.ISPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.ISFORCELAW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.ISCOMFORCELAW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.DOWNLOADSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.VALIDATESTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.PREACCEPTUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.REPUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.REPFINISHUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.DECLUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.PRIORITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.INSPNODE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.FOREIGNPROPERTY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.ISRETURN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.ASSISTPACKNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.FOREIGNCOMPANY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.ISDECLPLACE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.CSID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.MOID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.COID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.MOTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.CSTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPECTION_AFTER>()
        //        .Property(e => e.PAGENO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INVENTORYHISTORY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INVENTORYHISTORY>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INVENTORYHISTORY>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INVENTORYHISTORY>()
        //        .Property(e => e.ISDISTRIBUTE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INVENTORYHISTORY>()
        //        .Property(e => e.ACCEPTUSER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INVENTORYHISTORY>()
        //        .Property(e => e.ASSOCIATEUSER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INVENTORYHISTORY>()
        //        .Property(e => e.INVALIDUSER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ISBACK>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ISBACK>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_LICENSE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_LICENSE>()
        //        .Property(e => e.SELECTED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.LAWCONDITION)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.GOODSNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.CREATEUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.SUBMITUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.CSACCEPTUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.PRIORITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.GOODSGW)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.GOODSNW)
        //        .HasPrecision(18, 6);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.CSID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.MOID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.COID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.SECONDTRANSIT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.EXTRASTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.CSTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.SETNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.PAPERNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.MOACCEPTUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.COACCEPTUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.ISPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.DECLSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.INSPSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.DECLSETNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.INSPSETNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.DECLSHEETNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.INSPSHEETNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.PREDECLSETNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.PREINSPSETNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.MOTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.COTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.DECLPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.INSPPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.YWBH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.COBACK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.PAUSENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.MOACCEPTUSERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.COACCEPTUSERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.CSACCEPTUSERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.INVALIDREASON)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.BUSISHORTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.BUSISHORTCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.CSISBACK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.MOISBACK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.COISBACK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.INOUTTYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.IETYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.CSSUBMITUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.CSSUBMITUSERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.SPECIALRELATIONSHIP)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.PRICEIMPACT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.PAYPOYALTIES)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.PREISPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.SCENEDECLAREID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.SCENEINSPECTID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.DECLPDF)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.INSPPDF)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.CHECKPDF)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.PREPDF)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.ISTURNPRE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.SPLITNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.SELFCHECK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.ISSELFCHECK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.SELFCHECKUSERCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.SELFCHECKUSERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.WEIGHTCHECK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.ISWEIGHTCHECK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.WEIGHTCHECKUSERCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.WEIGHTCHECKUSERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.CHECKEDGOODSNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .Property(e => e.CHECKEDWEIGHT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDER>()
        //        .HasMany(e => e.CHATTOPICs)
        //        .WithOptional(e => e.LIST_ORDER)
        //        .HasForeignKey(e => e.ORDERID);

        //    modelBuilder.Entity<LIST_ORDERATTACHMENT>()
        //        .Property(e => e.ATTACHMENTSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDERATTACHMENT>()
        //        .Property(e => e.FILETYPEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDERRECORDER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDERRECORDER>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_ORDERRECORDER>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PAUSE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PAUSE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PAUSE>()
        //        .Property(e => e.ISEXPIRED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PAUSEOK>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PAUSEOK>()
        //        .Property(e => e.PID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PAUSEOK>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PAUSEOK>()
        //        .Property(e => e.ISOK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PAUSEOK>()
        //        .Property(e => e.POST)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLACCDOC>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLACCDOC>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLACCDOC>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLACCDOC>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLACCDOC_AFTER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLACCDOC_AFTER>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLACCDOC_AFTER>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLACCDOC_AFTER>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.DECLSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.GOODSNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.DECLARANT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.CSID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.MOID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.COID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.CLEARANCETYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.MOTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.CSTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.ISPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.PAGENO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.BACKSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.PAUSENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.MOSUBMITUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.SPECIALRELATIONSHIP)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.PRICEIMPACT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLARATION>()
        //        .Property(e => e.PAYPOYALTIES)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER>()
        //        .Property(e => e.CONTAINERORDER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER>()
        //        .Property(e => e.CONTAINERWEIGHT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER_AFTER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER_AFTER>()
        //        .Property(e => e.CONTAINERORDER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER_AFTER>()
        //        .Property(e => e.CONTAINERWEIGHT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER_AFTER>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER_AFTER>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLCONTAINER_AFTER>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.PREDECLID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.ORDERNO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.LEGALQUANTITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.SQUANTITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.CADQUANTITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.UNITPRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.TOTALPRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.PROCESSINGFEES)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.GOODSNW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.NEWNO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST>()
        //        .Property(e => e.ISSPECIAL)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.PREDECLID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.ORDERNO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.LEGALQUANTITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.SQUANTITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.CADQUANTITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.UNITPRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.TOTALPRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.GOODSNW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREDECLLIST_AFTER>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPCONTAINER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPCONTAINER>()
        //        .Property(e => e.NUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.INSPNODE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.FOREIGNPROPERTY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.ISRETURN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.GOODSNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.GOODSGW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.GOODSNW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.ASSISTPACKNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.FOREIGNCOMPANY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.ISDECLPLACE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.CSID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.MOID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.COID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.MOTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.CSTIME)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.ISPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.PAGENO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.PAUSENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPECTION>()
        //        .Property(e => e.MOSUBMITUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.PREINSPID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.ORDERNO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.GOODSNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.LEGALQUANTITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.SQUANTITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.UNITPRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.TOTALPRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.GOODSLENGTH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.GOODSWIDTH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.GOODSHIGH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.INSPNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.GOODSGW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.GOODSNW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.ASSITPACKAGENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.ASSITGOODSLENGTH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.ASSITGOODSWIDTH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.ASSITGOODSHIGH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.STANDARD)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.PRODUCTIONBATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.UNITYCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.NEWNO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST>()
        //        .Property(e => e.ISSPECIAL)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.PREINSPID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.ORDERNO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.GOODSNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.LEGALQUANTITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.SQUANTITY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.UNITPRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.TOTALPRICE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.GOODSLENGTH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.GOODSWIDTH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.GOODSHIGH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.INSPNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.GOODSGW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.GOODSNW)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.ASSITPACKAGENUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.ASSITGOODSLENGTH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.ASSITGOODSWIDTH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.ASSITGOODSHIGH)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.STANDARD)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.PRODUCTIONBATCH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_PREINSPLIST_AFTER>()
        //        .Property(e => e.UNITYCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<LIST_PRETCCGMAPPING>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCGMAPPING>()
        //        .Property(e => e.GOODSORDER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCGMAPPING>()
        //        .Property(e => e.CONTAINERORDER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCGMAPPING>()
        //        .Property(e => e.GOODSNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCGMAPPING>()
        //        .Property(e => e.GOODSWEIGHT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCGMAPPING>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCGMAPPING>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCGMAPPING>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCONTAINER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCONTAINER>()
        //        .Property(e => e.CONTAINERORDER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCONTAINER>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCONTAINER>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETCCONTAINER>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS>()
        //        .Property(e => e.BLORDER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS>()
        //        .Property(e => e.CONTAINERNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS_AFTER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS_AFTER>()
        //        .Property(e => e.BLORDER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS_AFTER>()
        //        .Property(e => e.CONTAINERNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS_AFTER>()
        //        .Property(e => e.CREATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS_AFTER>()
        //        .Property(e => e.UPDATEBY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_PRETRANCUSTOMS_AFTER>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_RECEIPTSTATUS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_RECEIPTSTATUS>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_RECEIPTSTATUS>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_RESENDHISTORY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_RESENDHISTORY>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_RESENDHISTORY>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_RESENDHISTORY>()
        //        .Property(e => e.RESENDNUM)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_SUBSCRIBE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_SUBSCRIBE>()
        //        .Property(e => e.SUBSCRIBEBYID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_SUBSCRIBE>()
        //        .Property(e => e.ISSUBSCRIBE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_SUBSCRIBE>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_SUBSCRIBE>()
        //        .Property(e => e.DONEBYID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_TIMES>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_TIMES>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_TIMES>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_TIMES>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_TIMES>()
        //        .Property(e => e.ISPAUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LOADDATA>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LOADDATA>()
        //        .Property(e => e.SPXS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LOADDATA>()
        //        .Property(e => e.ERROR)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<PDFSHRINKLOG>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<PDFSHRINKLOG>()
        //        .Property(e => e.ATTACHMENTID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<PDFSHRINKLOG>()
        //        .Property(e => e.ISCOMPRESS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_COMPANYNATURE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_COMPANYNATURE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_COMPANYNATURE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_COMPANYNATURE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_CONTAINER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_CONTAINER>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_CONTAINER>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_CONTAINER>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_COUNTRY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_COUNTRY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_COUNTRY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_COUNTRY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_COUNTRY>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_CURRENCY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_CURRENCY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_CURRENCY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_CURRENCY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_CURRENCY>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PACKAGE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PACKAGE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PACKAGE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PACKAGE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PACKAGE>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PORT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PORT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PORT>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PORT>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PORT>()
        //        .Property(e => e.KIND)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PRODUCTUNIT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PRODUCTUNIT>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PRODUCTUNIT>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PRODUCTUNIT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_PRODUCTUNIT>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_TRADE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_TRADE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_TRADE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_TRADE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_TRADE>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_TRANSPORT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_TRANSPORT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_TRANSPORT>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_TRANSPORT>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_WITHINREGION>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_WITHINREGION>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_WITHINREGION>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<RELA_WITHINREGION>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_BUSIKIND>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_BUSIKIND>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_BUSIKIND>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_BUSIKIND>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_BUSITYPE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_BUSITYPE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_BUSITYPE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_BUSITYPE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_CODE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_CODE>()
        //        .Property(e => e.ISENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_COMPANY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_COMPANY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.CHINESEABBREVIATION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.CHINESEADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.ISCUSTOMER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.ISSHIPPER)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.ISCOMPANY)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.SCENEDECLAREID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.SCENEINSPECTID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.SELFCHECK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_CUSTOMER>()
        //        .Property(e => e.WEIGHTCHECK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DECLARATIONCAR>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DECLARATIONCAR>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DECLARATIONCAR>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DECLARATIONCAR>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DECLWAY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DECLWAY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DECLWAY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DECLWAY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DEPARTMENT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DEPARTMENT>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DEPARTMENT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DEPARTMENT>()
        //        .Property(e => e.PARENTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_DEPARTMENT>()
        //        .Property(e => e.SORTINDEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_DEPARTMENT>()
        //        .Property(e => e.PATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_DEPARTMENT>()
        //        .Property(e => e.FULLNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_DEPARTMENT>()
        //        .Property(e => e.POSITIONID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_ENTRUSTTYPE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_ENTRUSTTYPE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_ENTRUSTTYPE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_ENTRUSTTYPE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_FTPSETTINGS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_FTPSETTINGS>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_GOODSTYPE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_GOODSTYPE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_GOODSTYPE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_GOODSTYPE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_INSPLIBRARY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_INSPLIBRARY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_INSPLIBRARY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_INSPLIBRARY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_INSPLIBRARY>()
        //        .Property(e => e.YEARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_INSPTYPE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_INSPTYPE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_INSPTYPE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_INSPTYPE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_MACADDRESS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_MACADDRESS>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_NOTICETYPE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_NOTICETYPE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_NOTICETYPE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_NOTICETYPE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_POSITION>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_POSITION>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_POSITION>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_POSITION>()
        //        .Property(e => e.DEPARTMENTID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_PROCEDUREMAPPING>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_PROCEDUREMAPPING>()
        //        .Property(e => e.TRANSACTION)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_PROCEDUREMAPPING>()
        //        .Property(e => e.ACTIVE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO>()
        //        .Property(e => e.ISMODEL)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO_DETAIL>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO_DETAIL>()
        //        .Property(e => e.RECORDINFOID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO_DETAIL>()
        //        .Property(e => e.ITEMNO)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO_DETAIL>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO_DETAIL>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO_DETAIL>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_RECORDINFO_DETAIL>()
        //        .Property(e => e.ABNORMAL)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REGUAREATYPE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REGUAREATYPE>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REGUAREATYPE>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REGUAREATYPE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REPORTLIBRARY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REPORTLIBRARY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REPORTLIBRARY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REPORTLIBRARY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REPWAY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REPWAY>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REPWAY>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_REPWAY>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_STATUS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_STATUS>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_STATUS>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_STATUS>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_TRMAPPING>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_TRMAPPING>()
        //        .Property(e => e.ACTIVE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_TRMAPPING>()
        //        .Property(e => e.PREINSERTFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_TRMAPPING>()
        //        .Property(e => e.POSTINSERTFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_TRMAPPING>()
        //        .Property(e => e.PREUPDATEFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_TRMAPPING>()
        //        .Property(e => e.POSTUPDATEFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_TRMAPPING>()
        //        .Property(e => e.PREDELETEFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_TRMAPPING>()
        //        .Property(e => e.POSTDELETEFLAG)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_UNITCONVERT>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_UNITCONVERT>()
        //        .Property(e => e.CONVERTRATE)
        //        .HasPrecision(7, 0);

        //    modelBuilder.Entity<SYS_UNITCONVERT>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_UNITCONVERT>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_UNITCONVERT>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.CUSTOMERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.SEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.POINTS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.AREAID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.POSITIONID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.PRETYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.PARENTID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.CURRENTIP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.CURRENTPORT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.CONNECTED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.FTPSERVERURL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_USER>()
        //        .Property(e => e.FTPPASSWORD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_USER>()
        //        .HasMany(e => e.CHATMESSAGEs)
        //        .WithOptional(e => e.SYS_USER)
        //        .HasForeignKey(e => e.CREATEUSER);

        //    modelBuilder.Entity<SYS_USER>()
        //        .HasMany(e => e.CHATMESSAGEs1)
        //        .WithOptional(e => e.SYS_USER1)
        //        .HasForeignKey(e => e.EDITUSER);

        //    modelBuilder.Entity<SYS_USER>()
        //        .HasMany(e => e.CHATMESSAGEs2)
        //        .WithOptional(e => e.SYS_USER2)
        //        .HasForeignKey(e => e.RECEVERUSER);

        //    modelBuilder.Entity<SYS_USER>()
        //        .HasMany(e => e.CHATMESSAGEs3)
        //        .WithOptional(e => e.SYS_USER3)
        //        .HasForeignKey(e => e.SENDUSER);

        //    modelBuilder.Entity<SYS_USER>()
        //        .HasMany(e => e.CHATTOPICs)
        //        .WithOptional(e => e.SYS_USER)
        //        .HasForeignKey(e => e.CREATEUSER);

        //    modelBuilder.Entity<SYS_USER>()
        //        .HasMany(e => e.CHATTOPICs1)
        //        .WithOptional(e => e.SYS_USER1)
        //        .HasForeignKey(e => e.EDITUSER);

        //    modelBuilder.Entity<SYS_WOODPACKING>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_WOODPACKING>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_WOODPACKING>()
        //        .Property(e => e.CREATEMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_WOODPACKING>()
        //        .Property(e => e.STOPMAN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSAPPLICATION>()
        //        .Property(e => e.APPLICATIONID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSAPPLICATION>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSAPPLICATION>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSAPPLICATION>()
        //        .Property(e => e.URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSAPPLICATION>()
        //        .Property(e => e.SORTINDEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSAUTH>()
        //        .Property(e => e.AUTHID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSAUTH>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSAUTH>()
        //        .Property(e => e.PARENTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSAUTH>()
        //        .Property(e => e.PATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSAUTH>()
        //        .Property(e => e.PATHLEVEL)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSAUTH>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSAUTH>()
        //        .Property(e => e.MODULEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSAUTH>()
        //        .Property(e => e.DATA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSAUTH>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSAUTH>()
        //        .Property(e => e.SORTINDEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSAUTHTYPE>()
        //        .Property(e => e.AUTHTYPEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.PARENTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.PATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.PATHLEVEL)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.SORTINDEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.EDITSTATUS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.TAG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.CREATERID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.CREATERNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.POSTLAVEL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.COMPANYID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.COMPANYNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.DEPTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.DEPTNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.EXT1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.EXT2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.EXT3)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.EXT4)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSENUMERATION>()
        //        .Property(e => e.EXT5)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTCONFIG>()
        //        .Property(e => e.ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTCONFIG>()
        //        .Property(e => e.APPCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTCONFIG>()
        //        .Property(e => e.DBCONSTR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTCONFIG>()
        //        .Property(e => e.DBTYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTCONFIG>()
        //        .Property(e => e.DBTABLENAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTCONFIG>()
        //        .Property(e => e.CREATENAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTCONFIG>()
        //        .Property(e => e.CREATEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTCONFIG>()
        //        .Property(e => e.SELECTSQL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTCONFIG>()
        //        .Property(e => e.SIGNFIELD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTLOG>()
        //        .Property(e => e.EVENTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTLOG>()
        //        .Property(e => e.LOGINNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTLOG>()
        //        .Property(e => e.USERID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTLOG>()
        //        .Property(e => e.APPLICATIONID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTLOG>()
        //        .Property(e => e.APPLICATIONCODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTLOG>()
        //        .Property(e => e.MODULEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTLOG>()
        //        .Property(e => e.AUTHID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTLOG>()
        //        .Property(e => e.IP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTLOG>()
        //        .Property(e => e.RECORD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTLOG>()
        //        .Property(e => e.ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSEVENTTYPE>()
        //        .Property(e => e.EVENTTYPEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.GROUPID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.PARENTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.PATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.PATHLEVEL)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.SORTINDEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.MODIFIEDSORTINDEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.HRCANCELED)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.PK_PSNDOC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.PK_PSNDOC2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.PK_PSNDOC3)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.WORTOUT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.ISABORT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUP>()
        //        .Property(e => e.ABORTDATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.MODULEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.APPLICATIONID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.PARENTID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.PATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.PATHLEVEL)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.ICON)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.SORTINDEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.EDITPAGEURL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMODULE>()
        //        .Property(e => e.AFTEREDITSCRIPT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMODULETYPE>()
        //        .Property(e => e.MODULETYPEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSMSGSENDED>()
        //        .Property(e => e.ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGSENDED>()
        //        .Property(e => e.SENDTOPHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGSENDED>()
        //        .Property(e => e.CONTENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGSENDED>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGSENDED>()
        //        .Property(e => e.EXT1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGSENDED>()
        //        .Property(e => e.EXT2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGSENDED>()
        //        .Property(e => e.EXT3)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGSENDED>()
        //        .Property(e => e.EXT4)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGSENDED>()
        //        .Property(e => e.EXT5)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGTOSEND>()
        //        .Property(e => e.ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGTOSEND>()
        //        .Property(e => e.SENDTOPHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGTOSEND>()
        //        .Property(e => e.CONTENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGTOSEND>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGTOSEND>()
        //        .Property(e => e.EXT1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGTOSEND>()
        //        .Property(e => e.EXT2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGTOSEND>()
        //        .Property(e => e.EXT3)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGTOSEND>()
        //        .Property(e => e.EXT4)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSMSGTOSEND>()
        //        .Property(e => e.EXT5)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSROLE>()
        //        .Property(e => e.ROLEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSROLE>()
        //        .Property(e => e.CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSROLE>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSROLE>()
        //        .Property(e => e.SORTINDEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSROLE>()
        //        .Property(e => e.SUPORIOR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSROLE>()
        //        .Property(e => e.PK_CORP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSROLE>()
        //        .Property(e => e.PK_DEPTDOC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSROLE>()
        //        .Property(e => e.PK_GWDJ)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSROLE>()
        //        .Property(e => e.WORTOUT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSROLE>()
        //        .Property(e => e.ISABORT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSROLE>()
        //        .Property(e => e.ABORTDATE)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSROLETYPE>()
        //        .Property(e => e.ROLETYPEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSROLETYPE>()
        //        .Property(e => e.NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSSYSTEM>()
        //        .Property(e => e.SYSTEMID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSSYSTEM>()
        //        .Property(e => e.ISCURRENT)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSTASK>()
        //        .Property(e => e.ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSTASK>()
        //        .Property(e => e.PID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSTASK>()
        //        .Property(e => e.WORKNO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSTASK>()
        //        .Property(e => e.STATUS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSTASK>()
        //        .Property(e => e.TYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSTASK>()
        //        .Property(e => e.URL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSTASK>()
        //        .Property(e => e.EXT1)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSTASK>()
        //        .Property(e => e.EXT2)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSTASK>()
        //        .Property(e => e.EXT3)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSTASK>()
        //        .Property(e => e.EXT4)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSTASK>()
        //        .Property(e => e.EXT5)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<T_DZ>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<T_JZX>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<T_MENU>()
        //        .Property(e => e.MENUID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<T_MENU>()
        //        .Property(e => e.PARENTMENUID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<T_ROLE>()
        //        .Property(e => e.ROLEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<T_ROLEMENU>()
        //        .Property(e => e.ROLEMENUID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<T_ROLEMENU>()
        //        .Property(e => e.ROLEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<T_ROLEMENU>()
        //        .Property(e => e.MENUID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<T_USERROLE>()
        //        .Property(e => e.USERROLEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<T_USERROLE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<T_USERROLE>()
        //        .Property(e => e.ROLEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<T_ZGFY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_28BACKFILL>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_28BACKFILL>()
        //        .Property(e => e.NODES)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_28BACKFILL>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_28BACKFILL>()
        //        .Property(e => e.ISBACK)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_DECLWRITE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_DECLWRITE>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_DECLWRITE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_INSPHISTORY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_INSPHISTORY>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_INSPWRITE>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_INSPWRITE>()
        //        .Property(e => e.STATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_INSPWRITE>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_INSPWRITE>()
        //        .Property(e => e.CHECKSTATUS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_INSPWRITE>()
        //        .Property(e => e.REPUSERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_ZGD>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_ZGD>()
        //        .Property(e => e.ISENABLED)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<USER_RENAME_COMPANY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<USER_RENAME_COMPANY>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<USER_RENAME_COMPANY>()
        //        .Property(e => e.COMPANYID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<USER_RENAME_COMPANY>()
        //        .Property(e => e.COMPANYCHNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<USER_RENAME_COMPANY>()
        //        .Property(e => e.COMPANYENNAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<USER_RENAME_COMPANY>()
        //        .Property(e => e.CUSTOMERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<USER_USE_DECLARATIONCAR>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<USER_USE_DECLARATIONCAR>()
        //        .Property(e => e.USERCOMPANYID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<USER_USE_DECLARATIONCAR>()
        //        .Property(e => e.DECLARATIONCARID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<USER_USE_DECLARATIONCAR>()
        //        .Property(e => e.MOTORCADE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<USER_USE_DECLARATIONCAR>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<YWTOTAL>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.TY_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.YLR_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.JKKA)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.BA_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.HG_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.HT_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.JYDW_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.JYDW_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.JYDW_XZ)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.SHDW_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.SHDW_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.SHDW_XZ)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.SBDW_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.SBDW_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.SBDW_XZ)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.YSFS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.YSGJ)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.HC_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.TIYUN_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.JGFS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.ZMXZ)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.ZSBL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.NSDW)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.XK_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.QYG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.ZHG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.JNMDD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.PZ_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.CJFS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.YUNFEE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.YBIZHONG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.BAOFEE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.BBIZHONG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.ZAFEE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.ZBIZHONG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.JIANSHU)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.BZZL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.MAOZHONG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.JINGZHONG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.JZX_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.SFDZ_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.BGDTYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.REMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.INOUTTYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.OPERTOR)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.PHONE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.SPXS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.YWBH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.SJRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.SJFLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.BGDTS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.FSRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.FSFLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.GJRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.GJFLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.BGDFLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.YSBGDH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_LOADDATA>()
        //        .Property(e => e.SJBGDTS)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.PID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.SP_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.BA_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.SPBH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.FJBH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.SPMC_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.GGXH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.CJ_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.CJDW)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.CJDJ)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.CJZJ)
        //        .HasPrecision(19, 4);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.BIZHONG)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.FD_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.FDDW)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.BBH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.HH_NO)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.YT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.DESL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.DEDW)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.YCD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.ZM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.GJF)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.SCCJ)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.GJRY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.GJFLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<BGJ_SUBDATA>()
        //        .Property(e => e.BGDFLAG)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATTOPICRECEIVER>()
        //        .Property(e => e.ID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<CHATTOPICRECEIVER>()
        //        .Property(e => e.RECEIVERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<CHATTOPICRECEIVER>()
        //        .Property(e => e.CHATTOPICID)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_CONFIGURE>()
        //        .Property(e => e.NAMEVALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_CONFIGURE>()
        //        .Property(e => e.SYMBOL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_CONFIGURE>()
        //        .Property(e => e.RULEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_CONFIGURE>()
        //        .Property(e => e.LOGIC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_CONFIGURE>()
        //        .Property(e => e.PAGEFILEDNUM)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_CONFIGURE>()
        //        .Property(e => e.FILEDTYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FIN_CONFIGURE>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<FIN_CONFIGURE>()
        //        .Property(e => e.RULESEQ)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPRECEIPTSTATUS>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPRECEIPTSTATUS>()
        //        .Property(e => e.TYPE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_INSPRECEIPTSTATUS>()
        //        .Property(e => e.ISINVALID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_UPDATEHISTORY>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<LIST_UPDATEHISTORY>()
        //        .Property(e => e.USERID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_FILETYPE>()
        //        .Property(e => e.FILETYPEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_FILETYPE>()
        //        .Property(e => e.FILETYPENAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_FILETYPE>()
        //        .Property(e => e.REMARK)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYS_FILETYPE>()
        //        .Property(e => e.PARENTFILETYPEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_FILETYPE>()
        //        .Property(e => e.FILEUSE)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_FILETYPE>()
        //        .Property(e => e.SORTINDEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_FILETYPE>()
        //        .Property(e => e.ENABLED)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_FILETYPE>()
        //        .Property(e => e.FILEKIND)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYS_FILETYPE>()
        //        .Property(e => e.EDOCFILETYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUPPERMISSION>()
        //        .Property(e => e.GROUPID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUPPERMISSION>()
        //        .Property(e => e.AUTHID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUPROLE>()
        //        .Property(e => e.GROUPID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSGROUPROLE>()
        //        .Property(e => e.ROLEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSROLEPERMISSION>()
        //        .Property(e => e.ROLEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSROLEPERMISSION>()
        //        .Property(e => e.AUTHID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSTEMSET>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.USERID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.GROUPID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.PK_USERID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.PK_GW)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.PK_DEPTDOC)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.PK_CORP)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.PK_ZW)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.PK_XL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.PK_RYLB)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.INDUTYDATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.HTBEGINDATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.HTENDDATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.PK_JNDJ)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.OUTDUTYDATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.POSTLAVEL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERGROUP>()
        //        .Property(e => e.DATATYPE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERPERMISSION>()
        //        .Property(e => e.USERID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERPERMISSION>()
        //        .Property(e => e.AUTHID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERPERMISSION>()
        //        .Property(e => e.GRANTEDBY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERROLE>()
        //        .Property(e => e.USERID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<SYSUSERROLE>()
        //        .Property(e => e.ROLEID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<T_CPINFO>()
        //        .Property(e => e.ID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_INSPWRITEMAPPING>()
        //        .Property(e => e.KIND)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_INSPWRITEMAPPING>()
        //        .Property(e => e.EXCELCOLUMN)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<TASK_ZC>()
        //        .Property(e => e.XZZT)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WEB_BANNER>()
        //        .Property(e => e.ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WEB_BANNER>()
        //        .Property(e => e.STATUS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WEB_BANNER>()
        //        .Property(e => e.SORTINDEX)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<WEB_NOTICE>()
        //        .Property(e => e.ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WEB_NOTICE>()
        //        .Property(e => e.CONTENT)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WEB_NOTICE>()
        //        .Property(e => e.CREATEID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<WEB_NOTICE>()
        //        .Property(e => e.AUDITID)
        //        .HasPrecision(38, 0);

        //    modelBuilder.Entity<WEB_NOTICE>()
        //        .Property(e => e.STATE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<WEB_NOTICE>()
        //        .Property(e => e.TYPE)
        //        .IsUnicode(false);
        //}
    }
}
