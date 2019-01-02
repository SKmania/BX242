using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BX24
{
    /// <summary>
    /// Логика взаимодействия для Tarif.xaml
    /// </summary>
    public partial class Tarif : Page
    {
        public Tarif()
        {
            InitializeComponent();
        }

         public bool formon=true;
        //public TimeSpan service_econom = new TimeSpan(0, 0, 0);
        public const int service_econom = 0;
        public const int service_standart = 3600;
        public const int service_proff = 7200;
        public const int service_prem = 10800;
        public const int depart_consult_manager_econom = 0;
        public const int depart_consult_manager_standart = 1;
        public const int depart_consult_manager_proff = 2;
        public const int depart_consult_manager_prem = 3;
        public const int extra_consult_econom = 0;
        public const int extra_consult_standart = 0;
        public const int extra_consult_proff = 0;
        public const int extra_consult_prem = 999999;
        int zagod=0;
        int date=0;
        DataTable table1 = new DataTable("table1");
        DataTable table2 = new DataTable("table2");
        DataTable table3 = new DataTable("table3");
        DataTable table4 = new DataTable("table4");
        DataTable table5 = new DataTable("table5");
        DataTable table6 = new DataTable("table6");
        DataTable table7 = new DataTable("table7");
        DataTable table8 = new DataTable("table5");
        DataTable table9 = new DataTable("table6");
        DataTable table10 = new DataTable("table7");

        DataSet company_list = new DataSet("company_list");
        DataTable companytable = new DataTable("company");
        DataColumn id_companyColumn = new DataColumn("id_company", Type.GetType("System.Int32"));
        DataColumn nameColumn = new DataColumn("name", Type.GetType("System.String"));
        DataColumn typeColumn = new DataColumn("type", Type.GetType("System.String"));
        DataColumn tariffColumn = new DataColumn("tariff", Type.GetType("System.String"));
        DataColumn TITLEColumn = new DataColumn("TITLE", Type.GetType("System.String"));
        DataColumn IDColumn = new DataColumn("ID", Type.GetType("System.Int32"));
        DataColumn DESCRIPTION2Column = new DataColumn("DESCRIPTION", Type.GetType("System.String"));
        DataColumn CREATED_BYColumn = new DataColumn("CREATED_BY", Type.GetType("System.String"));
        DataColumn DATE_STARTColumn = new DataColumn("DATE_START", Type.GetType("System.String"));
        DataColumn REAL_STATUSColumn = new DataColumn("REAL_STATUS", Type.GetType("System.String"));
        DataColumn CREATED_DATEColumn = new DataColumn("CREATED_DATE", Type.GetType("System.DateTime"));
        DataColumn TIME_SPENT_IN_LOGSColumn = new DataColumn("TIME_SPENT_IN_LOGS", Type.GetType("System.String"));
        DataColumn RESPONSIBLE_IDColumn = new DataColumn("RESPONSIBLE_ID", Type.GetType("System.String"));
        DataColumn TITLE1Column = new DataColumn("TITLE", Type.GetType("System.String"));
        DataColumn DESCRIPTION21Column = new DataColumn("DESCRIPTION", Type.GetType("System.String"));
        DataColumn REAL_STATUS1Column = new DataColumn("REAL_STATUS", Type.GetType("System.String"));
        DataColumn TIME_SPENT_IN_LOGS1Column = new DataColumn("TIME_SPENT_IN_LOGS", Type.GetType("System.String"));
        DataColumn TITLE2Column = new DataColumn("TITLE", Type.GetType("System.String"));
        DataColumn DESCRIPTION22Column = new DataColumn("DESCRIPTION", Type.GetType("System.String"));
        DataColumn REAL_STATUS2Column = new DataColumn("REAL_STATUS", Type.GetType("System.String"));
        DataColumn TIME_SPENT_IN_LOGS2Column = new DataColumn("TIME_SPENT_IN_LOGS", Type.GetType("System.String"));
        DataColumn TITLE3Column = new DataColumn("TITLE", Type.GetType("System.String"));
        DataColumn DESCRIPTION23Column = new DataColumn("DESCRIPTION", Type.GetType("System.String"));
        DataColumn REAL_STATUS3Column = new DataColumn("REAL_STATUS", Type.GetType("System.String"));
        DataColumn TIME_SPENT_IN_LOGS3Column = new DataColumn("TIME_SPENT_IN_LOGS", Type.GetType("System.String"));
        DataColumn TITLE4Column = new DataColumn("TITLE", Type.GetType("System.String"));
        DataColumn DESCRIPTION24Column = new DataColumn("DESCRIPTION", Type.GetType("System.String"));
        DataColumn REAL_STATUS4Column = new DataColumn("REAL_STATUS", Type.GetType("System.String"));
        DataColumn TIME_SPENT_IN_LOGS4Column = new DataColumn("TIME_SPENT_IN_LOGS", Type.GetType("System.String"));
        DataColumn TITLE5Column = new DataColumn("TITLE", Type.GetType("System.String"));
        DataColumn DESCRIPTION25Column = new DataColumn("DESCRIPTION", Type.GetType("System.String"));
        DataColumn REAL_STATUS5Column = new DataColumn("REAL_STATUS", Type.GetType("System.String"));
        DataColumn TIME_SPENT_IN_LOGS5Column = new DataColumn("TIME_SPENT_IN_LOGS", Type.GetType("System.String"));
        DataColumn TITLE6Column = new DataColumn("TITLE", Type.GetType("System.String"));
        DataColumn DESCRIPTION26Column = new DataColumn("DESCRIPTION", Type.GetType("System.String"));
        DataColumn REAL_STATUS6Column = new DataColumn("REAL_STATUS", Type.GetType("System.String"));
        DataColumn TIME_SPENT_IN_LOGS6Column = new DataColumn("TIME_SPENT_IN_LOGS", Type.GetType("System.String"));
        DataColumn TITLE7Column = new DataColumn("TITLE", Type.GetType("System.String"));
        DataColumn DESCRIPTION27Column = new DataColumn("DESCRIPTION", Type.GetType("System.String"));
        DataColumn REAL_STATUS7Column = new DataColumn("REAL_STATUS", Type.GetType("System.String"));
        DataColumn TIME_SPENT_IN_LOGS7Column = new DataColumn("TIME_SPENT_IN_LOGS", Type.GetType("System.String"));

        DataColumn TITLE8Column = new DataColumn("TITLE", Type.GetType("System.String"));
        DataColumn DESCRIPTION28Column = new DataColumn("DESCRIPTION", Type.GetType("System.String"));
        DataColumn REAL_STATUS8Column = new DataColumn("REAL_STATUS", Type.GetType("System.String"));
        DataColumn TIME_SPENT_IN_LOGS8Column = new DataColumn("TIME_SPENT_IN_LOGS", Type.GetType("System.String"));

        DataColumn TITLE9Column = new DataColumn("TITLE", Type.GetType("System.String"));
        DataColumn DESCRIPTION29Column = new DataColumn("DESCRIPTION", Type.GetType("System.String"));
        DataColumn REAL_STATUS9Column = new DataColumn("REAL_STATUS", Type.GetType("System.String"));
        DataColumn TIME_SPENT_IN_LOGS9Column = new DataColumn("TIME_SPENT_IN_LOGS", Type.GetType("System.String"));

        DataColumn TITLE10Column = new DataColumn("TITLE", Type.GetType("System.String"));
        DataColumn DESCRIPTION10Column = new DataColumn("DESCRIPTION", Type.GetType("System.String"));
        DataColumn REAL_STATUS10Column = new DataColumn("REAL_STATUS", Type.GetType("System.String"));
        DataColumn TIME_SPENT_IN_LOGS10Column = new DataColumn("TIME_SPENT_IN_LOGS", Type.GetType("System.String"));

        DataSet taskitemget = new DataSet("taskitemget");
        DataTable taskitemget_tbl = new DataTable("taskitemget_tbl");
        
        DataTable users = new DataTable("users");
        DataColumn ID_userColumn = new DataColumn("ID_user", Type.GetType("System.Int32"));
        DataColumn NAME_userColumn = new DataColumn("NAME_user", Type.GetType("System.String"));
        DataColumn LAST_NAMEColumn = new DataColumn("LAST_NAME", Type.GetType("System.String"));
        DataColumn PERSONAL_GENDERColumn = new DataColumn("PERSONAL_GENDER", Type.GetType("System.String"));
        DataColumn PERSONAL_BIRTHDAYColumn = new DataColumn("PERSONAL_BIRTHDAY", Type.GetType("System.String"));
        DataColumn PERSONAL_PHOTOColumn = new DataColumn("PERSONAL_PHOTO", Type.GetType("System.String"));
        DataColumn UF_PHONE_INNERColumn = new DataColumn("UF_PHONE_INNER", Type.GetType("System.Int32"));
        DataColumn WORK_POSITIONColumn = new DataColumn("WORK_POSITION", Type.GetType("System.String"));
        
        //ID, NAME, LAST_NAME, PERSONAL_GENDER, PERSONAL_BIRTHDAY, PERSONAL_PHOTO, UF_PHONE_INNER

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            podrobnyainfa podrobnyainfa = new podrobnyainfa();
            navreportdeep.Navigate(podrobnyainfa);
            gridreport.Visibility = Visibility.Collapsed;
            navreportdeep.Visibility = Visibility.Visible;
        }

        public static string ToDateSQLite(DateTime value)
        {
            string format_date = "yyyy-MM-dd HH:mm:ss.fff";
            return value.ToString(format_date);
        }
        public static class GlobalData
        {
            static public string[] key = new string[] { "no1nh7xi7zphwj3m", "pipd4hfyh9llq0av", "95d6l226gd2ucyza", "9kkiz6ugnujup0dk", "4eg7kw2yvm0paxyu" };
        };
        class Company
        {
            public string name { get; set; }
            public string type { get; set; }
            public string tariff { get; set; }
            public string id_company { get; set; }
            //public string Price { get; set; }
        }

        public async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(dateTimePicker1.DisplayDate);
            //int n=1;
            int total = 0;
            label1.Text = Convert.ToString(total);
            table1.Columns.Add(DESCRIPTION21Column);
            table1.Columns.Add(REAL_STATUS1Column);
            table1.Columns.Add(TIME_SPENT_IN_LOGS1Column);

            table2.Columns.Add(DESCRIPTION22Column);
            table2.Columns.Add(REAL_STATUS2Column);
            table2.Columns.Add(TIME_SPENT_IN_LOGS2Column);

            table3.Columns.Add(DESCRIPTION23Column);
            table3.Columns.Add(REAL_STATUS3Column);
            table3.Columns.Add(TIME_SPENT_IN_LOGS3Column);

            table4.Columns.Add(DESCRIPTION24Column);
            table4.Columns.Add(REAL_STATUS4Column);
            table4.Columns.Add(TIME_SPENT_IN_LOGS4Column);

            table5.Columns.Add(DESCRIPTION25Column);
            table5.Columns.Add(REAL_STATUS5Column);
            table5.Columns.Add(TIME_SPENT_IN_LOGS5Column);

            table6.Columns.Add(DESCRIPTION26Column);
            table6.Columns.Add(REAL_STATUS6Column);
            table6.Columns.Add(TIME_SPENT_IN_LOGS6Column);

            table7.Columns.Add(DESCRIPTION27Column);
            table7.Columns.Add(REAL_STATUS7Column);
            table7.Columns.Add(TIME_SPENT_IN_LOGS7Column);

            table8.Columns.Add(DESCRIPTION28Column);
            table8.Columns.Add(REAL_STATUS8Column);
            table8.Columns.Add(TIME_SPENT_IN_LOGS8Column);

            table9.Columns.Add(DESCRIPTION29Column);
            table9.Columns.Add(REAL_STATUS9Column);
            table9.Columns.Add(TIME_SPENT_IN_LOGS9Column);

            table10.Columns.Add(DESCRIPTION10Column);
            table10.Columns.Add(REAL_STATUS10Column);
            table10.Columns.Add(TIME_SPENT_IN_LOGS10Column);

            companytable.Columns.Add(id_companyColumn);
            companytable.Columns.Add(nameColumn);
            companytable.Columns.Add(typeColumn);
            companytable.Columns.Add(tariffColumn);
            taskitemget_tbl.Columns.Add(IDColumn);
            taskitemget_tbl.Columns.Add(TITLEColumn);
            taskitemget_tbl.Columns.Add(DESCRIPTION2Column);
            taskitemget_tbl.Columns.Add(CREATED_BYColumn);
            taskitemget_tbl.Columns.Add(DATE_STARTColumn);
            taskitemget_tbl.Columns.Add(REAL_STATUSColumn);
            taskitemget_tbl.Columns.Add(CREATED_DATEColumn);
            taskitemget_tbl.Columns.Add(TIME_SPENT_IN_LOGSColumn);
            taskitemget_tbl.Columns.Add(RESPONSIBLE_IDColumn);
            //users.Rows.Add(new object[] { ID, NAME, LAST_NAME, PERSONAL_GENDER, PERSONAL_BIRTHDAY, PERSONAL_PHOTO, PHONE_INNER });
            users.Columns.Add(ID_userColumn);
            users.Columns.Add(NAME_userColumn);
            users.Columns.Add(LAST_NAMEColumn);
            users.Columns.Add(PERSONAL_GENDERColumn);
            users.Columns.Add(PERSONAL_BIRTHDAYColumn);
            users.Columns.Add(PERSONAL_PHOTOColumn);
            users.Columns.Add(UF_PHONE_INNERColumn);
            users.Columns.Add(WORK_POSITIONColumn);

            try
            {
                XDocument xdoc = XDocument.Load("companydb.xml");
                var items = from xe in xdoc.Element("DocumentElement").Elements("company")
                            select new Company
                            {
                                id_company = xe.Element("id_company").Value,
                                name = xe.Element("name").Value,
                                type = xe.Element("type").Value,
                                tariff = xe.Element("tariff").Value
                            };
                foreach (var item in items)
                {
                    listBox1.Items.Add(item.name);
                    total++;
                }
                label1.Text = Convert.ToString(total);
            }
            catch (System.IO.FileNotFoundException)
            {
                ///нужно замустить уведомление о первом запуске
                //Гребанная асинхронность мне мозг
                //await Task.Run(() => RefreshData(total));

                Thread FirstThread = new Thread(RefreshData);
                FirstThread.Start();
            }
            Thread RefreshThread = new Thread(RefreshData);
            RefreshThread.Start();
            //RefreshData.cancel();
            //Thread.Join()
        }

        public void RefreshData()///int total обновление данных
        {
            while (formon == true)
            {
                DateTime now = DateTime.Today;
                DateTime now1 = new DateTime(now.Year, now.Month - 1, now.Day);
                DateTime test = new DateTime();
                string first = string.Format("{0:s}", now1);
                Console.WriteLine(first);
                string year = string.Format("{0:s}", test);
                string nowday = string.Format("{0:s}", now);
                Console.WriteLine(nowday);
                int total = 0;
                int total_task = 0;
                string indust;
                string tariff = null;
                int id_company = 0;
                string companies = null;
                string type = null;
                int ID = 0;
                string TITLE = null;
                string DESCRIPTION2 = null;
                string CREATED_BY = null;
                string DATE_START = null;
                string REAL_STATUS = null;
                string CREATED_DATE = null;
                string TIME_SPENT_IN_LOGS = null;
                string RESPONSIBLE_ID = null;

                int next = 0;
                try
                {
                    for (int i = 0; total >= next; next += 50, i++)
                    {
                        XmlDocument xDoc = new XmlDocument();
                        xDoc.Load($"https://profiescort.bitrix24.ru/rest/4334/{GlobalData.key[i]}/crm.company.list.xml?filter[!UF_CRM_1512462699]=null&filter[UF_CRM_1471578520]=1&select[]=UF_CRM_1512462699&select[]=TITLE&select[]=PHONE&select[]=INDUSTRY&start={next}");
                        //{ GlobalData.key[i]}
                        if (i == 4) { i = 0; }
                        XmlNodeList get_next = xDoc.SelectNodes("response");
                        XmlNodeList list = xDoc.SelectNodes("response/result/item");
                        foreach (XmlNode xnode in get_next)
                        {
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "total")
                                { total = Convert.ToInt16(childnode.InnerText); }
                            }
                        }
                        foreach (XmlNode xnode in list)
                        {
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "TITLE")
                                {
                                    companies = childnode.InnerText;
                                    companies = Regex.Replace(companies, @"[""]", ""); //фильтр входных данных легко настраиваемый
                                }
                                if (childnode.Name == "INDUSTRY")
                                {
                                    if (childnode.Name == null) { type = "ТОО"; }
                                    else
                                    {
                                        indust = childnode.InnerText;
                                        if (indust == "1") { type = "ГУ"; }
                                        else { type = "ТОО"; }
                                    }
                                }
                                if (childnode.Name == "ID")
                                { id_company = Convert.ToInt16(childnode.InnerText); }
                                if (childnode.Name == "UF_CRM_1512462699")
                                {
                                    switch (Convert.ToInt32(childnode.InnerText))
                                    {
                                        case 436:
                                            tariff = "Профессионал";
                                            break;
                                        case 434:
                                            tariff = "Стандарт";
                                            break;
                                        case 438:
                                            tariff = "Премиум";
                                            break;
                                        case 432:
                                            tariff = "Эконом";
                                            break;
                                        case 758:
                                            tariff = "Стандарт Техно";
                                            break;
                                        case 760:
                                            tariff = "Техническое обслуживание";
                                            break;
                                        case 762:
                                            tariff = "Программное обслуживание";
                                            break;
                                        case 430:
                                            tariff = "ИТС ТЕХНО";
                                            break;
                                        default:
                                            tariff = (childnode.InnerText);
                                            break;
                                    }
                                }
                            }
                            Thread.Sleep(100);
                            companytable.Rows.Add(new object[] { id_company, companies, type, tariff }); // добавляем
                        }
                    }
                    companytable.WriteXml("companydb.xml");
                    companytable.Rows.Clear();
                    next = 0;



                    ///далее обновление задач
                    ///await Task.Run(() => RefreshData(total));
                    for (int i = 0; total_task >= next; next += 50, i++)
                    {
                        XmlDocument xDoc1 = new XmlDocument();
                        if (i == 5) { i = 0; }

                        if (zagod == 0)
                        {
                            xDoc1.Load($"https://profiescort.bitrix24.ru/rest/4334/{GlobalData.key[i]}/task.item.list.xml?order[CREATED_DATE]=asc&filter[>CREATED_DATE]={year}&start={next}");
                        }
                        else if (zagod == 1)
                        {
                            xDoc1.Load($"https://profiescort.bitrix24.ru/rest/4334/{GlobalData.key[i]}/task.item.list.xml?order[CREATED_DATE]=asc&filter[>CREATED_DATE]={nowday}&start={next}");
                        }
                        else
                        {
                            xDoc1.Load($"https://profiescort.bitrix24.ru/rest/4334/{GlobalData.key[i]}/task.item.list.xml?order[CREATED_DATE]=asc&filter[>CREATED_DATE]={first}&start={next}");
                        }
                        XmlNodeList get_next = xDoc1.SelectNodes("response");
                        XmlNodeList list = xDoc1.SelectNodes("response/result/item");
                        foreach (XmlNode xnode in get_next)
                        {
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "total")
                                { total_task = Convert.ToInt16(childnode.InnerText); }
                            }
                        }
                        foreach (XmlNode xnode in list)
                        {
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "ID")
                                {
                                    ID = Convert.ToInt32(childnode.InnerText);
                                }
                                if (childnode.Name == "TITLE")
                                {
                                    TITLE = childnode.InnerText;
                                }
                                if (childnode.Name == "DESCRIPTION")
                                {
                                    DESCRIPTION2 = childnode.InnerText;
                                }
                                if (childnode.Name == "CREATED_BY")
                                {
                                    CREATED_BY = childnode.InnerText;
                                }
                                if (childnode.Name == "DATE_START")
                                {
                                    DATE_START = childnode.InnerText;
                                }
                                if (childnode.Name == "REAL_STATUS")
                                {
                                    if (Convert.ToInt16(childnode.InnerText) == 1)
                                    { REAL_STATUS = "Новая"; }
                                    if (Convert.ToInt16(childnode.InnerText) == 2)
                                    { REAL_STATUS = "Ожидает"; }
                                    if (Convert.ToInt16(childnode.InnerText) == 3)
                                    { REAL_STATUS = "В процессе"; }
                                    if (Convert.ToInt16(childnode.InnerText) == 4)
                                    { REAL_STATUS = "Предположительно завершена"; }
                                    if (Convert.ToInt16(childnode.InnerText) == 5)
                                    { REAL_STATUS = "Завершена"; }
                                    if (Convert.ToInt16(childnode.InnerText) == 6)
                                    { REAL_STATUS = "Отсрочена/отложена"; }
                                    if (Convert.ToInt16(childnode.InnerText) == 7)
                                    { REAL_STATUS = "Отменена"; }
                                    //REAL_STATUS = childnode.InnerText;
                                }
                                if (childnode.Name == "CREATED_DATE")
                                {
                                    //TimeSpan ts = new TimeSpan(0, 0, Convert.ToInt16(childnode.InnerText));
                                    CREATED_DATE = ToDateSQLite(Convert.ToDateTime(childnode.InnerText));
                                }
                                if (childnode.Name == "TIME_SPENT_IN_LOGS")
                                {
                                    TIME_SPENT_IN_LOGS = childnode.InnerText;
                                    //TimeSpan TIME_SPENT_IN_LOGS = new TimeSpan(0, 0, Convert.ToInt16(childnode.InnerText));
                                    //var ts = TimeSpan.FromSeconds(21355);
                                    //Console.WriteLine(ts.ToString());
                                    //Console.WriteLine("{0} д. {1} ч. {2} м. {3} с. {4} мс.", ts.Days, ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                                }
                                if (childnode.Name == "RESPONSIBLE_ID")
                                {
                                    RESPONSIBLE_ID = childnode.InnerText;
                                }
                            }
                            taskitemget_tbl.Rows.Add(new object[] { ID, TITLE, DESCRIPTION2, CREATED_BY, DATE_START, REAL_STATUS, CREATED_DATE, TIME_SPENT_IN_LOGS, RESPONSIBLE_ID }); // добавляем
                        }
                        Thread.Sleep(100);
                    }
                    if (zagod == 0)
                    {
                        taskitemget_tbl.WriteXml("taskyeardb.xml");
                    }
                    else if (zagod == 1)
                    {
                        taskitemget_tbl.WriteXml("tasknowdaydb.xml");
                    }
                    else
                    {
                        taskitemget_tbl.WriteXml("taskitemgetdb.xml");
                    }
                    zagod++;
                    taskitemget_tbl.Rows.Clear();
                    next = 0;
                    int total_users = 0;
                    string NAME = null;
                    string LAST_NAME = null;
                    string PERSONAL_GENDER = null;
                    string PERSONAL_BIRTHDAY = null;
                    int PHONE_INNER = 0;
                    string PERSONAL_PHOTO = null;
                    string WORK_POSITION = null;
                    for (int i = 0; total_users >= next; next += 50, i++)
                    {
                        XmlDocument xDoc2 = new XmlDocument();
                        if (i == 5) { i = 0; }
                        xDoc2.Load($"https://profiescort.bitrix24.ru/rest/4334/{GlobalData.key[i]}/user.get.xml?filter[UF_PHONE_INNER]=%%%&start={next}");
                        XmlNodeList get_next = xDoc2.SelectNodes("response");
                        XmlNodeList list = xDoc2.SelectNodes("response/result/item");
                        foreach (XmlNode xnode in get_next)
                        {
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "total")
                                { total_users = Convert.ToInt16(childnode.InnerText); }
                            }
                        }
                        foreach (XmlNode xnode in list)
                        {
                            foreach (XmlNode childnode in xnode.ChildNodes)
                            {
                                if (childnode.Name == "ID")
                                {
                                    ID = Convert.ToInt32(childnode.InnerText);
                                }
                                if (childnode.Name == "NAME")
                                {
                                    NAME = Convert.ToString(childnode.InnerText);
                                }
                                if (childnode.Name == "LAST_NAME")
                                {
                                    LAST_NAME = Convert.ToString(childnode.InnerText);
                                }
                                if (childnode.Name == "PERSONAL_GENDER")
                                {
                                    PERSONAL_GENDER = Convert.ToString(childnode.InnerText);
                                }
                                if (childnode.Name == "PERSONAL_BIRTHDAY")
                                {
                                    PERSONAL_BIRTHDAY = Convert.ToString(childnode.InnerText);
                                }
                                if (childnode.Name == "PERSONAL_PHOTO")
                                {
                                    try
                                    {
                                        using (WebClient webClient = new WebClient())
                                        {///-		$exception	{"Путь имеет недопустимую форму."}	System.ArgumentException

                                            byte[] data = webClient.DownloadData($"{childnode.InnerText}");

                                            using (MemoryStream mem = new MemoryStream(data))
                                            {
                                               /* using (var yourImage = Image.FromStream(mem))
                                                {
                                                    // If you want it as Png
                                                    yourImage.Save($"{NAME}_{LAST_NAME}.png", ImageFormat.Png);
                                                    // If you want it as Jpeg
                                                    //yourImage.Save("path_to_your_file.jpg", ImageFormat.Jpeg);
                                                }*/
                                            }

                                        }
                                        PERSONAL_PHOTO = $"{NAME}_{LAST_NAME}.png";
                                    }
                                    catch (System.ArgumentException)
                                    {
                                        PERSONAL_PHOTO = "Default";
                                    }
                                }
                                if (childnode.Name == "UF_PHONE_INNER")
                                {
                                    PHONE_INNER = Convert.ToInt32(childnode.InnerText);
                                }

                                if (childnode.Name == "WORK_POSITION")
                                {
                                    WORK_POSITION = Convert.ToString(childnode.InnerText);
                                }
                            }
                            users.Rows.Add(new object[] { ID, NAME, LAST_NAME, PERSONAL_GENDER, PERSONAL_BIRTHDAY, PERSONAL_PHOTO, PHONE_INNER, WORK_POSITION }); // добавляем

                        }
                        System.Threading.Thread.Sleep(100);

                    }
                    users.WriteXml("usersdb.xml");
                    users.Rows.Clear();
                    Thread.Sleep(2000);
                }
                catch (System.Net.WebException ex)
                {
                    MessageBox.Show("Hello MessageBox");
                    MessageBox.Show("No connect.", "Retry connect in 10 sec. Errorname:");
                    //MessageBox.Show("No connect.", "Retry connect in 10 sec. Errorname:" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Thread.Sleep(10000);
                }
            }
        }
    }
}

