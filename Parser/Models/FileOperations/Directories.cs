﻿using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Models.FileOperations
{
    static class Directories
    {
        public static void DirectoriesCheck()
        {
            string identity = Environment.UserDomainName + @"\" + Environment.UserName;
            FileSystemAccessRule accessRule = new FileSystemAccessRule(identity, FileSystemRights.ReadData, AccessControlType.Allow);
            DirectorySecurity onCreateSecurityRules = new DirectorySecurity();

            List<string> Dirs = new List<string>()
            {
                @"../search_info",
                @"../search_info/WIPO",
                @"../search_info/Espacenet",
                @"../search_info/ФИПС",
                @"../search_info/Яндекс.Патенты",
                @"../search_info/Роспатент",
                @"../search_info/Глобальный поиск",
                @"../search_info/Простой поиск",

                @"../Результаты поиска",
                @"../Результаты поиска/WIPO",
                @"../Результаты поиска/Espacenet",
                @"../Результаты поиска/ФИПС",
                @"../Результаты поиска/Яндекс.Патенты",
                @"../Результаты поиска/Роспатент",
                @"../Результаты поиска/Глобальный поиск",
                @"../Результаты поиска/Простой поиск"
            };

            onCreateSecurityRules.AddAccessRule(accessRule);

            foreach (var dir in Dirs)
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir, onCreateSecurityRules);
                    AddDirectorySecurity(dir, identity, FileSystemRights.Delete, AccessControlType.Allow);
                    AddDirectorySecurity(dir, identity, FileSystemRights.Write, AccessControlType.Allow);
                }
            }

            //foreach (var dir in Dirs)
            //    RemoveDirectorySecurity(dir, identity, FileSystemRights.Write, AccessControlType.Allow);
        }

        public static void AddDirectorySecurity(string DirName, string Account, FileSystemRights Rights, AccessControlType ControlType)
        {
            DirectoryInfo dInfo = new DirectoryInfo(DirName);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            dSecurity.AddAccessRule(new FileSystemAccessRule(Account, Rights, ControlType));
            dInfo.SetAccessControl(dSecurity);
        }

        public static void RemoveDirectorySecurity(string DirName, string Account, FileSystemRights Rights, AccessControlType ControlType)
        {
            DirectoryInfo dInfo = new DirectoryInfo(DirName);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            dSecurity.RemoveAccessRule(new FileSystemAccessRule(Account, Rights, ControlType));
            dInfo.SetAccessControl(dSecurity);
        }
    }
}
