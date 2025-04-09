

//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace DAL
{
    public class GlobalSessionCls
    {
        //public static string _ServerName
        //{
        //    get
        //    {
        //        if (HttpContext.Current.Session == null)
        //        {
        //            return string.Empty;
        //        }
        //        else
        //        if (HttpContext.Current.Session["_ServerName"] == null)
        //            return string.Empty;
        //        else
        //            return HttpContext.Current.Session["_ServerName"].ToString();
        //    }
        //    set
        //    {
        //        HttpContext.Current.Session["_ServerName"] = value;
        //    }
        //}

        //        public static string _ServerUserName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //                if (HttpContext.Current.Session["_ServerUserName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ServerUserName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_ServerUserName"] = value;
        //            }
        //        }
        //        public static string _ServerPassword
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_ServerPassword"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ServerPassword"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_ServerPassword"] = value;
        //            }
        //        }

        //        public static string _Mac
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_Mac"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Mac"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_Mac"] = value;
        //            }
        //        }

        //        public static string _EnableMac
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_EnableMac"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_EnableMac"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_EnableMac"] = value;
        //            }
        //        }
        //        public static string _APIUrl
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_APIUrl"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_APIUrl"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_APIUrl"] = value;
        //            }
        //        }

        //        public static string _APIImage
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_APIImage"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_APIImage"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_APIImage"] = value;
        //            }
        //        }


        //        public static string _PageTabs
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_PageTabs"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PageTabs"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PageTabs"] = value;
        //            }
        //        }

        //        public static string _PageUrl
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_PageUrl"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PageUrl"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PageUrl"] = value;
        //            }
        //        }
        //        public static string _CompDatabaseName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //                if (HttpContext.Current.Session["_CompDatabaseName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompDatabaseName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompDatabaseName"] = value;
        //            }
        //        }
        //        public static string _CompIniTial
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CompIniTial"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompIniTial"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompIniTial"] = value;
        //            }
        //        }

        //        //DAL.GlobalSessionCls._CompMessage = "";
        //        //DAL.GlobalSessionCls._CompMessageFontColor = "";


        //        public static string _CompMessage
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CompMessage"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompMessage"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompMessage"] = value;
        //            }
        //        }

        //        public static string _CompMessageFontColor
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CompMessageFontColor"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompMessageFontColor"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompMessageFontColor"] = value;
        //            }
        //        }
        //        //

        //        public static string _CompanyName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CompanyName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompanyName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompanyName"] = value;
        //            }
        //        }
        //        public static string _versionNo
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_versionNo"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_versionNo"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_versionNo"] = value;
        //            }
        //        }
        //        public static string _buildVersion
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_buildVersion"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_buildVersion"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_buildVersion"] = value;
        //            }
        //        }
        //        public static string _CompanyAliasName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CompanyAliasName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompanyAliasName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompanyAliasName"] = value;
        //            }
        //        }
        //        public static string _CompApproval
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CompApproval"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompApproval"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompApproval"] = value;
        //            }
        //        }
        //        public static string _SalesOrderApproval
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_SalesOrderApproval"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SalesOrderApproval"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SalesOrderApproval"] = value;
        //            }
        //        }
        //        public static string _PurchaseOrderApproval
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_PurchaseOrderApproval"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PurchaseOrderApproval"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PurchaseOrderApproval"] = value;
        //            }
        //        }
        //        public static string _UserApproval
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_UserApproval"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_UserApproval"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_UserApproval"] = value;
        //            }
        //        }
        //        public static string _Notification
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_Notification"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Notification"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_Notification"] = value;
        //            }
        //        }
        //        public static string _UNotification
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_UNotification"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_UNotification"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_UNotification"] = value;
        //            }
        //        }
        //        public static string _FinanceMenu
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_FinanceMenu"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_FinanceMenu"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FinanceMenu"] = value;
        //            }
        //        }
        //        public static string _SalesMenu
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_SalesMenu"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SalesMenu"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SalesMenu"] = value;
        //            }
        //        }
        //        public static string _PurchaseMenu
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_PurchaseMenu"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PurchaseMenu"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PurchaseMenu"] = value;
        //            }
        //        }
        //        public static string _InventoryMenu
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_InventoryMenu"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_InventoryMenu"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_InventoryMenu"] = value;
        //            }
        //        }
        //        public static string _Branch_Code
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_Branch_Code"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Branch_Code"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Branch_Code"] = value;
        //            }
        //        }
        //        public static string _Branch_Name
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_Branch_Name"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Branch_Name"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Branch_Name"] = value;
        //            }
        //        }
        //        public static string _Branch_ShortName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_Branch_ShortName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Branch_ShortName"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Branch_ShortName"] = value;
        //            }
        //        }
        //        public static bool _IsCompanyUnit
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_IsCompanyUnit"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_IsCompanyUnit"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_IsCompanyUnit"] = value;
        //            }
        //        }
        //        public static string _CmpUnit_Code
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CmpUnit_Code"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CmpUnit_Code"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_CmpUnit_Code"] = value;
        //            }
        //        }

        //        public static string _fiscalYear
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_fiscalYear"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_fiscalYear"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_fiscalYear"] = value;
        //            }
        //        }
        //        public static string _Login_Type
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_Login_Type"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Login_Type"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Login_Type"] = value;
        //            }
        //        }
        //        public static string _CmpUnit_Name
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CmpUnit_Name"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CmpUnit_Name"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_CmpUnit_Name"] = value;
        //            }
        //        }
        //        public static string _CmpUnit_ShortName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CmpUnit_ShortName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CmpUnit_ShortName"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_CmpUnit_ShortName"] = value;
        //            }
        //        }
        //        public static string _CmpUnit_Address
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CmpUnit_Address"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CmpUnit_Address"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_CmpUnit_Address"] = value;
        //            }
        //        }
        //        public static string _CmpUnit_PhoneNo
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CmpUnit_PhoneNo"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CmpUnit_PhoneNo"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_CmpUnit_PhoneNo"] = value;
        //            }
        //        }
        //        public static string _CompanyStartDate
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CompanyStartDate"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompanyStartDate"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompanyStartDate"] = value;
        //            }
        //        }
        //        public static string _CompanyEnddate
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CompanyEnddate"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompanyEnddate"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompanyEnddate"] = value;
        //            }
        //        }
        //        public static string _CompanyAddress
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CompanyAddress"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompanyAddress"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompanyAddress"] = value;
        //            }
        //        }
        //        public static string _CompanyPhone
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session["_CompanyPhone"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompanyPhone"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompanyPhone"] = value;
        //            }
        //        }
        //        public static string _CompanyPanNo
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CompanyPanNo"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompanyPanNo"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompanyPanNo"] = value;
        //            }
        //        }
        //        public static string _CompanyEmail
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CompanyEmail"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CompanyEmail"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CompanyEmail"] = value;
        //            }
        //        }
        //        public static string _LoginUserCode
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_LoginUserCode"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_LoginUserCode"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_LoginUserCode"] = value;
        //            }
        //        }

        //        public static string _LoginGuid
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_LoginGuid"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_LoginGuid"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_LoginGuid"] = value;
        //            }
        //        }
        //        public static string _UserType
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_UserType"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_UserType"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_UserType"] = value;
        //            }
        //        }
        //        public static string _UserAuthorize
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_UserAuthorize"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_UserAuthorize"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_UserAuthorize"] = value;
        //            }
        //        }

        //        public static string _UserAuthorizeOrNotification
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_UserAuthorizeOrNotification"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_UserAuthorizeOrNotification"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_UserAuthorizeOrNotification"] = value;
        //            }
        //        }
        //        public static bool _UserAuth
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_UserAuth"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_UserAuth"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_UserAuth"] = value;
        //            }
        //        }
        //        public static bool _UserNotification
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_UserNotification"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_UserNotification"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_UserNotification"] = value;
        //            }
        //        }
        //        public static string _RateModification
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_RateModification"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_RateModification"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_RateModification"] = value;
        //            }
        //        }
        //        public static string _windowsurl
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_windowsurl"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_windowsurl"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_windowsurl"] = value;
        //            }
        //        }
        //        public static string _LoginUserName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_LoginUserName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_LoginUserName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_LoginUserName"] = value;
        //            }
        //        }

        //        public static string _ApprovalCompany
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_ApprovalCompany"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ApprovalCompany"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_ApprovalCompany"] = value;
        //            }
        //        }
        //        public static string _Usernotification
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_Usernotification"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Usernotification"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_Usernotification"] = value;
        //            }
        //        }
        //        public static string _RangeApproval
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_RangeApproval"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_RangeApproval"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_RangeApproval"] = value;
        //            }
        //        }
        //        public static string _FinanceApproval
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_FinanceApproval"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_FinanceApproval"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FinanceApproval"] = value;
        //            }
        //        }
        //        public static string _CustomerCode
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else
        //               if (HttpContext.Current.Session["_CustomerCode"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CustomerCode"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CustomerCode"] = value;
        //            }
        //        }
        //        public static string _EmployeeId
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_EmployeeId"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_EmployeeId"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_EmployeeId"] = value;
        //            }
        //        }
        //        public static string _EmployeeHeadId
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_EmployeeHeadId"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_EmployeeHeadId"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_EmployeeHeadId"] = value;
        //            }
        //        }
        //        public static bool _IsEmployeeHead
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_IsEmployeeHead"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_IsEmployeeHead"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_IsEmployeeHead"] = value;
        //            }
        //        }
        //        public static string _EmployeeDepartmentId
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_EmployeeDepartmentId"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_EmployeeDepartmentId"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_EmployeeDepartmentId"] = value;
        //            }
        //        }
        //        public static string _EmployeeBranchId
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_EmployeeBranchId"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_EmployeeBranchId"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_EmployeeBranchId"] = value;
        //            }
        //        }

        //        public static string _IpAddress
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_IpAddress"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_IpAddress"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_IpAddress"] = value;
        //            }
        //        }

        //        #region -------- System Control Value -------
        //        public static string _GlCode
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_GlCode"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_GlCode"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_GlCode"] = value;
        //            }
        //        }
        //        public static string _GlDesc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_GlDesc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_GlDesc"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_GlDesc"] = value;
        //            }
        //        }
        //        public static string _PCode
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PCode"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PCode"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PCode"] = value;
        //            }
        //        }
        //        public static string _PDesc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PDesc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PDesc"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PDesc"] = value;
        //            }
        //        }
        //        public static string _CashBank
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_CashBank"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CashBank"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CashBank"] = value;
        //            }
        //        }
        //        public static string _CashBankDesc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_CashBankDesc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CashBankDesc"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CashBankDesc"] = value;
        //            }
        //        }
        //        public static string _CardAccount
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_CardAccount"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CardAccount"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CardAccount"] = value;
        //            }
        //        }
        //        public static string _SUpdateRate
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_SUpdateRate"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SUpdateRate"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SUpdateRate"] = value;
        //            }
        //        }
        //        public static string _CardAccountDesc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_CardAccountDesc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CardAccountDesc"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_CardAccountDesc"] = value;
        //            }
        //        }
        //        public static string _PLAccount
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PLAccount"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PLAccount"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PLAccount"] = value;
        //            }
        //        }
        //        public static string _VatAccount
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_VatAccount"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_VatAccount"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_VatAccount"] = value;
        //            }
        //        }
        //        public static string _VatAccountDesc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_VatAccountDesc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_VatAccountDesc"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_VatAccountDesc"] = value;
        //            }
        //        }
        //        public static char _LedgerShortNameWise
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return Convert.ToChar(0);
        //                }
        //                else if (HttpContext.Current.Session["_LedgerShortNameWise"] == null)
        //                    return Convert.ToChar(0);
        //                else
        //                    return Convert.ToChar(HttpContext.Current.Session["_LedgerShortNameWise"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_LedgerShortNameWise"] = value;
        //            }
        //        }
        //        public static string _SalesAc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_SalesAc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SalesAc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_SalesAc"] = value;
        //            }
        //        }
        //        public static string _SalesReturn
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_SalesReturn"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SalesReturn"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_SalesReturn"] = value;
        //            }
        //        }
        //        public static string _SalesExpBrkReturn
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_SalesExpBrkReturn"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SalesExpBrkReturn"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_SalesExpBrkReturn"] = value;
        //            }
        //        }
        //        public static string _InterBranchSalesAc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_InterBranchSalesAc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_InterBranchSalesAc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_InterBranchSalesAc"] = value;
        //            }
        //        }
        //        public static int _Vat
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return 0;
        //                }
        //                else if (HttpContext.Current.Session["_Vat"] == null)
        //                    return 0;
        //                else
        //                    return Convert.ToInt32(HttpContext.Current.Session["_Vat"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_Vat"] = value;
        //            }
        //        }
        //        public static int _SalesDisTerm//Billwise
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return 0;
        //                }
        //                else if (HttpContext.Current.Session["_SalesDisTerm"] == null)
        //                    return 0;
        //                else
        //                    return Convert.ToInt32(HttpContext.Current.Session["_SalesDisTerm"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SalesDisTerm"] = value;
        //            }
        //        }
        //        public static int _DisTerm//Productwise
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return 0;
        //                }
        //                else if (HttpContext.Current.Session["_DisTerm"] == null)
        //                    return 0;
        //                else
        //                    return Convert.ToInt32(HttpContext.Current.Session["_DisTerm"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_DisTerm"] = value;
        //            }
        //        }
        //        public static int _SpcDisTerm
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return 0;
        //                }
        //                else if (HttpContext.Current.Session["_SpcDisTerm"] == null)
        //                    return 0;
        //                else
        //                    return Convert.ToInt32(HttpContext.Current.Session["_SpcDisTerm"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SpcDisTerm"] = value;
        //            }
        //        }
        //        public static int _SerTerm
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return 0;
        //                }
        //                else if (HttpContext.Current.Session["_SerTerm"] == null)
        //                    return 0;
        //                else
        //                    return Convert.ToInt32(HttpContext.Current.Session["_SerTerm"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SerTerm"] = value;
        //            }
        //        }
        //        public static string _PurchaseAc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PurchaseAc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PurchaseAc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_PurchaseAc"] = value;
        //            }
        //        }
        //        public static string _PurchaseReturn
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PurchaseReturn"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PurchaseReturn"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_PurchaseReturn"] = value;
        //            }
        //        }
        //        public static string _PurchaseExpBrkReturn
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PurchaseExpBrkReturn"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PurchaseExpBrkReturn"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_PurchaseExpBrkReturn"] = value;
        //            }
        //        }
        //        public static string _InterBranchPurchaseAc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_InterBranchPurchaseAc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_InterBranchPurchaseAc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_InterBranchPurchaseAc"] = value;
        //            }
        //        }
        //        public static int _PurchaseVat
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return 0;
        //                }
        //                else if (HttpContext.Current.Session["_PurchaseVat"] == null)
        //                    return 0;
        //                else
        //                    return Convert.ToInt32(HttpContext.Current.Session["_PurchaseVat"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PurchaseVat"] = value;
        //            }
        //        }
        //        public static string _PurchaseAcGroup//Vendor/Creditors Ac Group
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PurchaseAcGroup"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PurchaseAcGroup"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_PurchaseAcGroup"] = value;
        //            }
        //        }
        //        public static string _EComUserAcGroup//Customer/Debitors Ac Group
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_EComUserAcGroup"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_EComUserAcGroup"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_EComUserAcGroup"] = value;
        //            }
        //        }
        //        public static string _OpeningPLAc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_OpeningPLAc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_OpeningPLAc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_OpeningPLAc"] = value;
        //            }
        //        }
        //        public static string _OpeningPLAcDesc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_OpeningPLAcDesc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_OpeningPLAcDesc"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_OpeningPLAcDesc"] = value;
        //            }
        //        }
        //        public static string _ClosingPLAc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_ClosingPLAc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ClosingPLAc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_ClosingPLAc"] = value;
        //            }
        //        }
        //        public static string _ClosingPLAcDesc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_ClosingPLAcDesc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ClosingPLAcDesc"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_ClosingPLAcDesc"] = value;
        //            }
        //        }
        //        public static string _ClosingBSAc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_ClosingBSAc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ClosingBSAc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_ClosingBSAc"] = value;
        //            }
        //        }
        //        public static string _ClosingBSAcDesc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_ClosingBSAcDesc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ClosingBSAcDesc"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_ClosingBSAcDesc"] = value;
        //            }
        //        }
        //        public static string _ProductionLedger
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_ProductionLedger"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ProductionLedger"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_ProductionLedger"] = value;
        //            }
        //        }
        //        public static string _ProductionLedgerDesc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_ProductionLedgerDesc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ProductionLedgerDesc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_ProductionLedgerDesc"] = value;
        //            }
        //        }
        //        public static string _RawMaterialPCode
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_RawMaterialPCode"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_RawMaterialPCode"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_RawMaterialPCode"] = value;
        //            }
        //        }
        //        public static string _RawMaterialPDesc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_RawMaterialPDesc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_RawMaterialPDesc"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_RawMaterialPDesc"] = value;
        //            }
        //        }
        //        public static string _DisplayBatchName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_DisplayBatchName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_DisplayBatchName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_DisplayBatchName"] = value;
        //            }
        //        }
        //        //for fields in batch popup

        //        public static string _DisplayBatchName2
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return "Field2";
        //                }
        //                else if (HttpContext.Current.Session["_DisplayBatchName2"] == null)
        //                    return "Field2";
        //                else
        //                    return HttpContext.Current.Session["_DisplayBatchName2"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_DisplayBatchName2"] = value;
        //            }
        //        }
        //        public static string _DisplayBatchName3
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return "Field3";
        //                }
        //                else if (HttpContext.Current.Session["_DisplayBatchName3"] == null)
        //                    return "Field3";
        //                else
        //                    return HttpContext.Current.Session["_DisplayBatchName3"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_DisplayBatchName3"] = value;
        //            }
        //        }
        //        public static string _DisplayBatchName4
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return "Field4";
        //                }
        //                else if (HttpContext.Current.Session["_DisplayBatchName4"] == null)
        //                    return "Field4";
        //                else
        //                    return HttpContext.Current.Session["_DisplayBatchName4"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_DisplayBatchName4"] = value;
        //            }
        //        }
        //        //
        //        public static bool _EnableDisplayBatchName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_EnableDisplayBatchName"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_EnableDisplayBatchName"].ToString());
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_EnableDisplayBatchName"] = value;
        //            }
        //        }
        //        public static char _DateMiti
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return Convert.ToChar('D');
        //                }
        //                else if (HttpContext.Current.Session["_DateMiti"] == null)
        //                    return Convert.ToChar('D');
        //                else
        //                    return Convert.ToChar(HttpContext.Current.Session["_DateMiti"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_DateMiti"] = value;
        //            }
        //        }
        //        public static string _CurrentDate
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return "0";
        //                }
        //                else if (HttpContext.Current.Session["_CurrentDate"] == null)
        //                    return ("0");
        //                else
        //                    return (HttpContext.Current.Session["_CurrentDate"].ToString());
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_CurrentDate"] = value;
        //            }
        //        }
        //        public static string _CurrDesc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_CurrDesc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CurrDesc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Cur_Code"] = value;
        //            }
        //        }
        //        public static int _Backup_Sch_Int_Days
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return 0;
        //                }
        //                else if (HttpContext.Current.Session["_Backup_Sch_Int_Days"] == null)
        //                    return 0;
        //                else
        //                    return Convert.ToInt32(HttpContext.Current.Session["_Backup_Sch_Int_Days"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_Backup_Sch_Int_Days"] = value;
        //            }
        //        }
        //        public static string _BackupPath
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_BackupPath"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_BackupPath"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_BackupPath"] = value;
        //            }
        //        }
        //        public static bool _Negative_Tran
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_Negative_Tran"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_Negative_Tran"].ToString());
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Negative_Tran"] = value;
        //            }
        //        }
        //        public static string _AmountFormat
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_AmountFormat"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_AmountFormat"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_AmountFormat"] = value;
        //            }
        //        }
        //        public static string _RateFormat
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_RateFormat"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_RateFormat"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_RateFormat"] = value;
        //            }
        //        }
        //        public static string _QtyFormat
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_QtyFormat"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_QtyFormat"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_QtyFormat"] = value;
        //            }
        //        }
        //        public static string _CurFormat
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_CurFormat"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_CurFormat"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_CurFormat"] = value;
        //            }
        //        }

        //        public static string _UserRightType
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return "D";
        //                }
        //                else if (HttpContext.Current.Session["_UserRightType"] == null)
        //                    return "D";
        //                else
        //                    return HttpContext.Current.Session["_UserRightType"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_UserRightType"] = value;
        //            }
        //        }
        //        public static string _GroupName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_GroupName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_GroupName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_GroupName"] = value;
        //            }
        //        }
        //        public static string _SubGroupName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_SubGroupName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SubGroupName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SubGroupName"] = value;
        //            }
        //        }
        //        public static string _Group1Name
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_Group1Name"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Group1Name"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_Group1Name"] = value;
        //            }
        //        }
        //        public static string _Group2Name
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_Group2Name"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Group2Name"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_Group2Name"] = value;
        //            }
        //        }
        //        public static string _ELevel
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_ELevel"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ELevel"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_ELevel"] = value;
        //            }
        //        }
        //        public static string _ESubject
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_ESubject"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ESubject"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_ESubject"] = value;
        //            }
        //        }
        //        public static string _ELanguage
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_ELanguage"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_ELanguage"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_ELanguage"] = value;
        //            }
        //        }
        //        public static string _EBook
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["EBook"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["EBook"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["EBook"] = value;
        //            }
        //        }


        //        public static string _SendSMSOnSave
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_SendSMSOnSave"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SendSMSOnSave"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SendSMSOnSave"] = value;
        //            }
        //        }
        //        public static string _SendEmailOnSave
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_SendEmailOnSave"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SendEmailOnSave"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SendEmailOnSave"] = value;
        //            }
        //        }
        //        public static string _OutstandingVoucher
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_OutstandingVoucher"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_OutstandingVoucher"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_OutstandingVoucher"] = value;
        //            }
        //        }
        //        public static string _Font_Name
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_Font_Name"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Font_Name"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Font_Name"] = value;
        //            }
        //        }
        //        public static decimal _Font_Size
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return 0;
        //                }
        //                else if (HttpContext.Current.Session["_Font_Size"] == null)
        //                    return 0;
        //                else
        //                    return Convert.ToDecimal(HttpContext.Current.Session["_Font_Size"].ToString());
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Font_Size"] = value;
        //            }
        //        }
        //        public static string _Paper_Size
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_Paper_Size"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Paper_Size"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Paper_Size"] = value;
        //            }
        //        }
        //        public static bool _Printing_DateTime
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_Printing_DateTime"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_Printing_DateTime"].ToString());
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Printing_DateTime"] = value;
        //            }
        //        }
        //        public static bool _CodeMode
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_CodeMode"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_CodeMode"].ToString());
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_CodeMode"] = value;
        //            }
        //        }
        //        public static bool _DivisionwiseProduct
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_DivisionwiseProduct"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_DivisionwiseProduct"].ToString());
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_DivisionwiseProduct"] = value;
        //            }
        //        }
        //        public static bool _ProductGroupwiseDisplay
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_ProductGroupwiseDisplay"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_ProductGroupwiseDisplay"].ToString());
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_ProductGroupwiseDisplay"] = value;
        //            }
        //        }
        //        public static string _Email_Id
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_Email_Id"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Email_Id"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Email_Id"] = value;
        //            }
        //        }
        //        public static string _Email_Password
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_Email_Password"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Email_Password"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_Email_Password"] = value;
        //            }
        //        }
        //        public static int _FiscalYear_Id
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return 0;
        //                }
        //                else if (HttpContext.Current.Session["_FiscalYear_Id"] == null)
        //                    return 0;
        //                else
        //                    return Convert.ToInt32(HttpContext.Current.Session["_FiscalYear_Id"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FiscalYear_Id"] = value;
        //            }
        //        }
        //        public static string _PreviousYearDbName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PreviousYearDbName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PreviousYearDbName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PreviousYearDbName"] = value;
        //            }
        //        }
        //        //---------Control Validation---------------
        //        //Finance Control Validation
        //        public static bool _FINCurrencyEnable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINCurrencyEnable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINCurrencyEnable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINCurrencyEnable"] = value;
        //            }
        //        }
        //        public static bool _FINCurrencyMandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINCurrencyMandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINCurrencyMandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINCurrencyMandatory"] = value;
        //            }
        //        }
        //        public static bool _FINAgentEnable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINAgentEnable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINAgentEnable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINAgentEnable"] = value;
        //            }
        //        }
        //        public static bool _FINAgentMandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINAgentMandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINAgentMandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINAgentMandatory"] = value;
        //            }
        //        }
        //        public static bool _FINClassEnable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClassEnable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClassEnable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClassEnable"] = value;
        //            }
        //        }
        //        public static bool _FINClassMandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClassMandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClassMandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClassMandatory"] = value;
        //            }
        //        }
        //        public static bool _FINClass2Enable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass2Enable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass2Enable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClass2Enable"] = value;
        //            }
        //        }
        //        public static bool _FINClass2Mandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass2Mandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass2Mandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClass2Mandatory"] = value;
        //            }
        //        }
        //        public static bool _FINClass3Enable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass3Enable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass3Enable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClass3Enable"] = value;
        //            }
        //        }
        //        public static bool _FINClass3Mandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass3Mandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass3Mandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClass3Mandatory"] = value;
        //            }
        //        }
        //        public static bool _FINClass4Enable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass4Enable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass4Enable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClass4Enable"] = value;
        //            }
        //        }
        //        public static bool _FINClass4Mandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass4Mandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass4Mandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClass4Mandatory"] = value;
        //            }
        //        }
        //        public static bool _FINClassItemEnable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClassItemEnable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClassItemEnable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClassItemEnable"] = value;
        //            }
        //        }
        //        public static bool _FINClassItemMandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClassItemMandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClassItemMandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClassItemMandatory"] = value;
        //            }
        //        }
        //        public static bool _FINClass2ItemEnable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass2ItemEnable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass2ItemEnable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClass2ItemEnable"] = value;
        //            }
        //        }
        //        public static bool _FINClass2ItemMandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass2ItemMandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass2ItemMandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClass2ItemMandatory"] = value;
        //            }
        //        }
        //        public static bool _FINClass3ItemEnable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass3ItemEnable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass3ItemEnable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClass3ItemEnable"] = value;
        //            }
        //        }
        //        public static bool _FINClass3ItemMandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass3ItemMandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass3ItemMandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClassItemMandatory"] = value;
        //            }
        //        }
        //        public static bool _FINClass4ItemEnable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass4ItemEnable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass4ItemEnable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClass4ItemEnable"] = value;
        //            }
        //        }
        //        public static bool _FINClass4ItemMandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINClass4ItemMandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINClass4ItemMandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINClass4ItemMandatory"] = value;
        //            }
        //        }
        //        public static bool _FINSubLedgerEnable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINSubLedgerEnable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINSubLedgerEnable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINSubLedgerEnable"] = value;
        //            }
        //        }
        //        public static bool _FINSubLedgerMandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINSubLedgerMandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINSubLedgerMandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINSubLedgerMandatory"] = value;
        //            }
        //        }
        //        public static bool _FINVoucherDateEnable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINVoucherDateEnable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINVoucherDateEnable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINVoucherDateEnable"] = value;
        //            }
        //        }
        //        public static bool _FINNarrationEnable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINNarrationEnable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINNarrationEnable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINNarrationEnable"] = value;
        //            }
        //        }
        //        public static bool _FINRemarksEnable
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINRemarksEnable"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINRemarksEnable"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINRemarksEnable"] = value;
        //            }
        //        }
        //        public static bool _FINRemarksMandatory
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_FINRemarksMandatory"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_FINRemarksMandatory"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_FINRemarksMandatory"] = value;
        //            }
        //        }
        //        //------------End Control Validation----------------
        //        public static string _DocumentNoInvoice
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_DocumentNoInvoice"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_DocumentNoInvoice"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_DocumentNoInvoice"] = value;
        //            }
        //        }     // for pos and restaurant bill print
        //        public static string _DocumentNoOrder
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_DocumentNoOrder"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_DocumentNoOrder"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_DocumentNoOrder"] = value;
        //            }
        //        }       // for pos and restaurant bill print
        //        public static string _DefaultInvoiceDesign
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_DefaultInvoiceDesign"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_DefaultInvoiceDesign"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_DefaultInvoiceDesign"] = value;
        //            }
        //        }  // for pos and restaurant bill print
        //        public static string _DefaultOrderDesign
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_DefaultOrderDesign"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_DefaultOrderDesign"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_DefaultOrderDesign"] = value;
        //            }
        //        }   // for pos and restaurant bill print
        //        #endregion 
        //        public static string _IRDAPIUserName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["IRDAPIUserName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["IRDAPIUserName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["IRDAPIUserName"] = value;
        //            }
        //        }
        //        public static string _IRDAPIPassword
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_IRDAPIPassword"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_IRDAPIPassword"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_IRDAPIPassword"] = value;
        //            }
        //        }
        //        public static string _IRDAPISellerPan
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_IRDAPISellerPan"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_IRDAPISellerPan"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_IRDAPISellerPan"] = value;
        //            }
        //        }
        //        public static string _IRDAPIURL
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_IRDAPIURL"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_IRDAPIURL"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_IRDAPIURL"] = value;
        //            }
        //        }
        //        public static string _SysSerialNo
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_SysSerialNo"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SysSerialNo"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SysSerialNo"] = value;
        //            }
        //        }
        //        public static string _SysReglNo
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_SysReglNo"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SysReglNo"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SysReglNo"] = value;
        //            }
        //        }
        //        public static string _SysExpDate
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_SysExpDate"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SysExpDate"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SysExpDate"] = value;
        //            }
        //        }
        //        public static int _IsProjectVersion
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return 0;
        //                }
        //                else if (HttpContext.Current.Session["_IsProjectVersion"] == null)
        //                    return 0;
        //                else
        //                    return Convert.ToInt32(HttpContext.Current.Session["_IsProjectVersion"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_IsProjectVersion"] = value;
        //            }
        //        }
        //        public static string _IsProjectEdition
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_IsProjectEdition"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_IsProjectEdition"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_IsProjectEdition"] = value;
        //            }
        //        }
        //        public static string _IsRealIrdUpdate
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_IsRealIrdUpdate"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_IsRealIrdUpdate"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_IsRealIrdUpdate"] = value;
        //            }
        //        }
        //        public static string _IsDirectPrint
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_IsDirectPrint"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_IsDirectPrint"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_IsDirectPrint"] = value;
        //            }
        //        }

        //        public static string _IsFinanceDirectPrint
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_IsFinanceDirectPrint"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_IsFinanceDirectPrint"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_IsFinanceDirectPrint"] = value;
        //            }
        //        }
        //        public static string _InsuranceGlAc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_InsuranceGlAc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_InsuranceGlAc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_InsuranceGlAc"] = value;
        //            }
        //        }
        //        public static string _RenewalGlAc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_RenewalGlAc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_RenewalGlAc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_RenewalGlAc"] = value;
        //            }
        //        }
        //        public static string _PaymentGlAc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PaymentGlAc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PaymentGlAc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_PaymentGlAc"] = value;
        //            }
        //        }
        //        public static string _DeprecationGlAc
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_DeprecationGlAc"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_DeprecationGlAc"].ToString();
        //            }

        //            set
        //            {
        //                HttpContext.Current.Session["_DeprecationGlAc"] = value;
        //            }
        //        }
        //        public static bool _AuthPost
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_AuthPost"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_AuthPost"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_AuthPost"] = value;
        //            }
        //        }
        //        public static bool _AutoProvisionalVoucherPosting
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return false;
        //                }
        //                else if (HttpContext.Current.Session["_AutoProvisionalVoucherPosting"] == null)
        //                    return false;
        //                else
        //                    return Convert.ToBoolean(HttpContext.Current.Session["_AutoProvisionalVoucherPosting"].ToString());
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_AutoProvisionalVoucherPosting"] = value;
        //            }
        //        }
        //        public static string _TodayMiti
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_TodayMiti"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_TodayMiti"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_TodayMiti"] = value;
        //            }
        //        }
        //        public static DataTable _UrlNotPermission
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    DataTable dt = new DataTable();
        //                    return dt;
        //                }
        //                else if (HttpContext.Current.Session["_UrlNotPermission"] == null)
        //                {
        //                    DataTable dt = new DataTable();
        //                    return dt;
        //                }

        //                else
        //                    return HttpContext.Current.Session["_UrlNotPermission"] as DataTable;
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_UrlNotPermission"] = value;
        //            }
        //        }



        //        public static string _SelectedUnitList
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_SelectedUnitList"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_SelectedUnitList"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_SelectedUnitList"] = value;
        //            }
        //        }
        //        public static string _LoginUserType
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_LoginUserType"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_LoginUserType"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_LoginUserType"] = value;
        //            }
        //        }
        //        public static string _LoginServiceUser
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_LoginServiceUser"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_LoginServiceUser"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_LoginServiceUser"] = value;
        //            }
        //        }

        //        #region Payroll
        //        public static string _PayrollDatabaseName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollDatabaseName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PayrollDatabaseName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollDatabaseName"] = value;
        //            }
        //        }
        //        public static string _isErp
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return "";
        //                }
        //                else if (HttpContext.Current.Session["_isERP"] == null)
        //                    return "";
        //                else
        //                    return HttpContext.Current.Session["_isErp"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_isErp"] = value;
        //            }
        //        }

        //        public static string _PayrollMachineDatabaseName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollMachineDatabaseName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PayrollMachineDatabaseName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollMachineDatabaseName"] = value;
        //            }
        //        }
        //        public static string _PayrollCompanyName
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollCompanyName"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PayrollCompanyName"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollCompanyName"] = value;
        //            }
        //        }
        //        public static string _PayrollCompanyAddress
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollCompanyAddress"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PayrollCompanyAddress"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollCompanyAddress"] = value;
        //            }
        //        }
        //        public static string _PayrollCompanyPhone
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollCompanyPhone"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PayrollCompanyPhone"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollCompanyPhone"] = value;
        //            }
        //        }
        //        public static string _PayrollCompanyPanNo
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollCompanyPanNo"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PayrollCompanyPanNo"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollCompanyPanNo"] = value;
        //            }
        //        }
        //        public static string _PayrollBranchId
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollBranchId"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PayrollBranchId"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollBranchId"] = value;
        //            }
        //        }
        //        public static string _PayrollDateType
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollDateType"] == null)
        //                    return "D";
        //                else
        //                    return HttpContext.Current.Session["_PayrollDateType"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollDateType"] = value;
        //            }
        //        }
        //        public static string _PayrollSalaryCalType
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollSalaryCalType"] == null)
        //                    return "D";
        //                else
        //                    return HttpContext.Current.Session["_PayrollSalaryCalType"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollSalaryCalType"] = value;
        //            }
        //        }
        //        public static string _PayrollPostAccDr
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollPostAccDr"] == null)
        //                    return "D";
        //                else
        //                    return HttpContext.Current.Session["_PayrollPostAccDr"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollPostAccDr"] = value;
        //            }
        //        }
        //        public static string _PayrollPostAccCr
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollPostAccCr"] == null)
        //                    return "D";
        //                else
        //                    return HttpContext.Current.Session["_PayrollPostAccCr"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollPostAccCr"] = value;
        //            }
        //        }
        //        public static string _PayrollAdvanceAccCr
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollAdvanceAccCr"] == null)
        //                    return "D";
        //                else
        //                    return HttpContext.Current.Session["_PayrollAdvanceAccCr"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollAdvanceAccCr"] = value;
        //            }
        //        }
        //        public static string _PayrollLoanAccDr
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollLoanAccDr"] == null)
        //                    return "D";
        //                else
        //                    return HttpContext.Current.Session["_PayrollLoanAccDr"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollLoanAccDr"] = value;
        //            }
        //        }
        //        public static string _PayrollEMail
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollEMail"] == null)
        //                    return "D";
        //                else
        //                    return HttpContext.Current.Session["_PayrollEMail"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollEMail"] = value;
        //            }
        //        }
        //        public static string _PayrollEMailPassword
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollEMailPassword"] == null)
        //                    return "D";
        //                else
        //                    return HttpContext.Current.Session["_PayrollEMailPassword"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollEMailPassword"] = value;
        //            }
        //        }

        //        public static string _Browser
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_Browser"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Browser"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_Browser"] = value;
        //            }
        //        }
        //        public static string _LoginLogo
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_LoginLogo"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_LoginLogo"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_LoginLogo"] = value;
        //            }
        //        }
        //        public static string _PendingTaskCount
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PendingTaskCount"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PendingTaskCount"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PendingTaskCount"] = value;
        //            }
        //        }
        //        public static string _Pendingunapprove
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_Pendingunapprove"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_Pendingunapprove"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_Pendingunapprove"] = value;
        //            }
        //        }

        //        public static string _PayrollAccountPostingDB
        //        {
        //            get
        //            {
        //                if (HttpContext.Current.Session == null)
        //                {
        //                    return string.Empty;
        //                }
        //                else if (HttpContext.Current.Session["_PayrollAccountPostingDB"] == null)
        //                    return string.Empty;
        //                else
        //                    return HttpContext.Current.Session["_PayrollAccountPostingDB"].ToString();
        //            }
        //            set
        //            {
        //                HttpContext.Current.Session["_PayrollAccountPostingDB"] = value;
        //            }
        //        }

        //        #endregion
    }
}