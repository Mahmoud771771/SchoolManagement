﻿namespace SchoolProject.Data.AppMetaData
{
    public static class Router
    {
        public const string Root = "api";
        public const string SingleRoute = "/{id}";
        public const string Version = "V1";
        public const string Rule = Root + "/" + Version + "/";

        public static class StudentRouting
        {
            public const string Prefix = Rule + "Student";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + SingleRoute;
            public const string Create = Prefix + "/Create";
            public const string Edit = Prefix + "/Edit";
            public const string Delete = Prefix + "{id}";
            public const string Paginated = Prefix + "/Paginated";


        }
        public static class DepartmentRouting
        {
            public const string Prefix = Rule + "Department";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + "/Id";
            public const string Create = Prefix + "/Create";
            public const string Edit = Prefix + "/Edit";
            public const string Delete = Prefix + "{id}";
            public const string Paginated = Prefix + "/Paginated";


        }

    }
}
