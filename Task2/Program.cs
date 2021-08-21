namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            DelegatesLogic.SortList sl = new DelegatesLogic.SortList();
            sl.OnGetInput += DelegatesMethods.sl_OnGetInput;
            sl.GetNumber();
        }
    }
}