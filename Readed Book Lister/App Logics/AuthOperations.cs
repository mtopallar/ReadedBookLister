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

        const string userFileName = "users.json";

        public static void Register(UserLoginDto UserLoginDto)
        {
            JsonOperations.CreateDbFilesIfNot();

            var getUserList = UserOperations.GetAllUsers();
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(StringUtilityHelper.TrimStartAndFinish(UserLoginDto.Password), out passwordHash, out passwordSalt);

            if (getUserList == null)
            {
                var newUserList = new List<User>
                {
                    new User
                    {
                        Id = IdGeneratorForNewUser(),
                        NickName = StringUtilityHelper.TrimStartAndFinish(UserLoginDto.NickName),
                        PasswordSalt = passwordSalt,
                        PasswordHash = passwordHash
                    }

                };

                var convertNewListToJson = JsonConvert.SerializeObject(newUserList, Formatting.Indented);
                File.WriteAllText(userFileName, convertNewListToJson);
                System.Windows.Forms.MessageBox.Show(Messages.RegisterSuccessful);
                return;
            }

            else if (UserOperations.IsNickNameExists(UserLoginDto.NickName))
            {

                User user = new()
                {
                    Id = IdGeneratorForNewUser(),
                    NickName = StringUtilityHelper.TrimStartAndFinish(UserLoginDto.NickName),
                    PasswordSalt = passwordSalt,
                    PasswordHash = passwordHash
                };
                getUserList.Add(user);
                var convertListToJson = JsonConvert.SerializeObject(getUserList, Formatting.Indented);
                File.WriteAllText(userFileName, convertListToJson);
                System.Windows.Forms.MessageBox.Show(Messages.RegisterSuccessful);
            }

        }

        public static bool Login(UserLoginDto userLoginDto)
        {
            var user = UserOperations.GetByNickName(userLoginDto.NickName);
            if (user != null)
            {
                if (HashingHelper.VerifyPasswordHash(StringUtilityHelper.TrimStartAndFinish(userLoginDto.Password), user.PasswordHash, user.PasswordSalt))
                {
                    return true;
                }
                System.Windows.Forms.MessageBox.Show(Messages.LoginError);
            }

            return false;
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
