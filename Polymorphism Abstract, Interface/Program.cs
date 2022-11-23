namespace Polymorphism_Abstract__Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Homework
            ////string test = "bu bir test mesajidir";
            ////for (int i = 0; i < test.Length; i++)
            ////{
            ////    if (!char.IsUpper(test[0]))
            ////    {
            ////        break;
            ////    }
            ////}

            //string username;
            //string pw;
            //do
            //{
            //    Console.WriteLine("Please enter username");
            //    username = Console.ReadLine();
            //} while (username.Length <= 6);
            //do
            //{
            //    Console.WriteLine("Please enter password");
            //    pw = Console.ReadLine();
            //} while (!CheckPassword(pw));

            //bool result;
            //char yesOrNo;

            //do
            //{
            //    Console.WriteLine("Is super admin? y/n");
            //    result = char.TryParse(Console.ReadLine(), out yesOrNo);
            //} while (!result);

            //Admin admin;
            //if (yesOrNo.ToString().ToLower() == 'y'.ToString())
            //{
            //    admin = new(username, pw, "Blog", true);
            //}
            //else
            //{
            //    admin = new(username, pw, "Blog");
            //}

            //admin.ShowAllInfos(); 
            #endregion

            #region Get set accessor and readonly keyword
            //Rashid rashid = new Rashid("test");

            //rashid.IsSnitch = false;

            //Console.WriteLine(rashid.IsSnitch);
            //Console.WriteLine(rashid.Meaningless); 
            #endregion


            #region Polymorphism
            //Gun gun = new Gun();

            //gun.Reload();

            //AK47 ak = new();

            //ak.Reload();

            //UZI uzi = new UZI();

            //uzi.Reload(); 
            #endregion

            //Human human = new Human();

            Student student = new();

            student.Eat();

        }
        static bool CheckPassword(string pw)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            bool result = false;
            foreach (char charachter in pw)
            {
                if (char.IsDigit(charachter))
                {
                    hasDigit = true;
                }
                else if (char.IsLower(charachter))
                {
                    hasLower = true;
                }
                else if (char.IsUpper(charachter))
                {
                    hasUpper = true;
                }
                result = hasDigit && hasLower && hasUpper;
                if (result)
                {
                    break;
                }

            }
            return result;
        }
    }
}