using Newtonsoft.Json;
using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Dtos;
using Readed_Book_Lister.Entities;
using Readed_Book_Lister.Methods.App_Methods;
using Readed_Book_Lister.Methods.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readed_Book_Lister.App_Logics
{
    public class AuthOperations
    {   // Mbox kontrolleri de ok
        //Register => ok.
        //Login => ok. 

        //Checked.

        const string userFileName = "users.json";

        public static User? Register(UserLoginDto UserLoginDto)
        {
            JsonOperations.CreateDbFilesIfNot();

            var getUserList = UserOperations.GetAllUsers();
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(StringUtilityHelper.TrimStartAndFinish(UserLoginDto.Password), out passwordHash, out passwordSalt);
            User user = new();

            if (getUserList == null)
            {
                user.Id = IdGeneratorForNewUser();
                user.NickName = StringUtilityHelper.TrimStartAndFinish(UserLoginDto.NickName);
                user.PasswordSalt = passwordSalt;
                user.PasswordHash = passwordHash;

                var newUserList = new List<User>
                {
                   user
                };

                var convertNewListToJson = JsonConvert.SerializeObject(newUserList, Formatting.Indented);
                File.WriteAllText(userFileName, convertNewListToJson);
                System.Windows.Forms.MessageBox.Show(Messages.RegisterSuccessful);
                return user;
            }            

            else if (UserOperations.IsNickNameExists(UserLoginDto.NickName))
            {
                user.Id = IdGeneratorForNewUser();
                user.NickName = StringUtilityHelper.TrimStartAndFinish(UserLoginDto.NickName);
                user.PasswordSalt = passwordSalt;
                user.PasswordHash = passwordHash;

                getUserList.Add(user);
                var convertListToJson = JsonConvert.SerializeObject(getUserList, Formatting.Indented);
                File.WriteAllText(userFileName, convertListToJson);
                System.Windows.Forms.MessageBox.Show(Messages.RegisterSuccessful);
                return user;

            }
            
            return null;
        }

        public static User? Login(UserLoginDto userLoginDto)
        {
            var user = UserOperations.GetByNickName(userLoginDto.NickName);
            if (user != null)
            {
                if (HashingHelper.VerifyPasswordHash(StringUtilityHelper.TrimStartAndFinish(userLoginDto.Password), user.PasswordHash, user.PasswordSalt))
                {
                    return user;
                }
                System.Windows.Forms.MessageBox.Show(Messages.LoginError);
                return null;
            }
            System.Windows.Forms.MessageBox.Show(Messages.UserNotFoundByName);
            return null;
        }

        private static int IdGeneratorForNewUser()
        {
            int minId = 1;
            var getUserList = UserOperations.GetAllUsers();
            if (getUserList == null)
            {
                return minId;
            }
            return (getUserList.OrderByDescending(u => u.Id).First().Id) + 1;
        }
    }
}
