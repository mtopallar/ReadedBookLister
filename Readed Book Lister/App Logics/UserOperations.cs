using Newtonsoft.Json;
using Readed_Book_Lister.Constants;
using Readed_Book_Lister.Dtos;
using Readed_Book_Lister.Entities;
using Readed_Book_Lister.Methods.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readed_Book_Lister.Methods.App_Methods
{
    public class UserOperations
    {
        //Checked.

        // Mbox kontrolleri de ok.
        // add (auth a alındı) ok
        // update => ok
        // delete => ok
        // get all => ok
        // get by id => ok
        // IsNickNameExist => ok
        // GetByNickName => ok
        const string userFileName = "users.json";

        public static void Update(UserUpdateDto userUpdateDto)
        {
            var getUser = GetUserById(userUpdateDto.Id);
            if (getUser != null)
            {
                if (IsNickNameExists(StringUtilityHelper.TrimStartAndFinish(userUpdateDto.NewNickName)))
                {
                    if (HashingHelper.VerifyPasswordHash(StringUtilityHelper.TrimStartAndFinish(userUpdateDto.CurrentPassword), getUser.PasswordHash, getUser.PasswordSalt))
                    {
                        byte[] passwordHash, passwordSalt;
                        HashingHelper.CreatePasswordHash(StringUtilityHelper.TrimStartAndFinish(userUpdateDto.NewPassword), out passwordHash, out passwordSalt);
                        getUser.Id = userUpdateDto.Id;
                        getUser.NickName = userUpdateDto.NewNickName;
                        getUser.PasswordHash = passwordHash;
                        getUser.PasswordSalt = passwordSalt;

                        var getAllUsers = GetAllUsers();
                        if (getAllUsers != null) //defensive programming
                        {
                            var oldUser = getAllUsers.Where(u => u.Id == userUpdateDto.Id).FirstOrDefault();
                            oldUser = getUser; //referans tip olduğu için getAll daki veri de değişmiş olmalı.
                            var convertUpdatedListToJson = JsonConvert.SerializeObject(getAllUsers, Formatting.Indented);
                            File.WriteAllText(userFileName, convertUpdatedListToJson);
                            System.Windows.Forms.MessageBox.Show(Messages.UserUpdateSuccesful);
                            return;
                        }

                        return;
                    }

                    System.Windows.Forms.MessageBox.Show(Messages.CurrentPasswordError);
                    return;
                }

            }
        }
        public static void Delete(int userId)
        {
            var getAllUsers = GetAllUsers();
            if (getAllUsers != null)
            {
                var getUserToDelete = GetUserById(userId);
                if (getUserToDelete != null)
                {
                    getAllUsers.Remove(getUserToDelete);
                    var convertDeletedListToJson = JsonConvert.SerializeObject(getAllUsers, Formatting.Indented);
                    File.WriteAllText(userFileName, convertDeletedListToJson);
                    System.Windows.Forms.MessageBox.Show(Messages.DeleteUserSuccesful);
                    JsonOperations.DeleteUserFile();
                }

            }

        }

        public static User? GetUserById(int id)
        {
            var jsonUserList = File.ReadAllText(userFileName);
            var userList = JsonConvert.DeserializeObject<List<User>>(jsonUserList);
            if (userList != null)
            {
                var getUserById = userList.Where(u => u.Id == id).FirstOrDefault();
                if (getUserById != null)
                {
                    return getUserById;
                }

            }
            System.Windows.Forms.MessageBox.Show(Messages.UserNotFoundById);
            return null;

        }
        public static List<User>? GetAllUsers()
        {
            var jsonUserList = File.ReadAllText(userFileName);
            var userList = JsonConvert.DeserializeObject<List<User>>(jsonUserList);
            if (userList != null)
            {
                if (userList.Count != 0)
                {
                    return userList;
                }
                System.Windows.Forms.MessageBox.Show(Messages.UsersListIsEmpty);
                return null;
            }
            System.Windows.Forms.MessageBox.Show(Messages.UsersFileNotExist);
            return null;
        }

        public static User? GetByNickName(string nickName)
        {
            var userList = GetAllUsers();
            if (userList != null)
            {
                var returnUser = userList.Where(u => u.NickName == StringUtilityHelper.TrimStartAndFinish(nickName)).FirstOrDefault();
                if (returnUser != null)
                {
                    return returnUser;
                }
            }
            System.Windows.Forms.MessageBox.Show(Messages.UserNotFoundByName);
            return null;

        }

        public static bool IsNickNameExists(string nickName)
        {
            var tryGetByNickName = GetByNickName(StringUtilityHelper.TrimStartAndFinish(nickName));
            if (tryGetByNickName != null)
            {
                System.Windows.Forms.MessageBox.Show(Messages.NickNameExists);
                return false;
            }
            return true;
        }
    }
}
