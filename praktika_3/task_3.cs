using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        class SQLCommand
        {
            private string[] sql_operate = { "select", "from", "where", "group by", "having", "order by", "create database", "create table", "alter table", "insert", "select", "and", "or", "between", "limit", "update", "delete", "drop column", "drop table", "count", "sum", "avg", "min", "max", "as", "inner join", "view", "union", "outer join", "exist", "regexp", "like", "distinct", "ifnull", "if", "case", "on", "right join", "left join", "values", "all" };
            private char[] let;

            public string CommandText
            {
                get;
                set;
            }
            public string Sql_up()
            {
                for (int i = 0; i < sql_operate.Length; i++)
                {
                    if (CommandText.Contains(sql_operate[i]))
                    {
                        int index = CommandText.IndexOf(sql_operate[i], StringComparison.CurrentCultureIgnoreCase);
                        int j = 0;
                        let = CommandText.ToCharArray();
                        while ((CommandText[index] == sql_operate[i][j]))
                        {
                            let[index] = char.ToUpper(let[index]);
                            index++;
                            j++;
                            if (j == sql_operate[i].Length)
                            {
                                break;
                            }
                            if (index == CommandText.Length)
                            {
                                string sq;
                                sq = new string(let);
                                return sq;
                                break;
                            }
                        }
                    }

                }
                return "Missing operators";
            }


        }

        static void Main(string[] args)
        {
            SQLCommand cmd = new SQLCommand();
            cmd.CommandText = "fefsefs from";
            cmd.Sql_up();

        }
    }
}