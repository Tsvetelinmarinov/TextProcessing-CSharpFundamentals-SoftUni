/*
 * Draft
 */

using System.Text;

/// code =>

StringBuilder sb = new("Tsvetelin", 30);
sb.AppendFormat(" - {0} - ", 23);
sb.AppendJoin(" - ", new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
Console.WriteLine(sb);