using System;
using System.Text;

class User {
    public string Login = string.Empty;
    public int Age = 0;
    public User(string loginUser, int ageUser) {
        Login = loginUser;
        Age = ageUser;
    }
}

sealed class ChainCheckingsOfUser {
    public delegate bool IsConditionOk(User user);

    private List<IsConditionOk> arrayCheckers = new List<IsConditionOk>();
    private User? _user = null;

    public ChainCheckingsOfUser(User user) {
        _user = user;
    }

    public ChainCheckingsOfUser AddChecker(IsConditionOk checker) {
        arrayCheckers.Add(checker);
        return this;
    }

    public bool RunCheck() {
        if(null == _user) {
            return false;
        }
        foreach (IsConditionOk checker in arrayCheckers) {
            bool condition = checker(_user);
            if (!condition) return false;
        }
        return true;
    }
}

static class UserPropsChecker {
    public static bool IsUserAdult(User user) {
        bool result = (user.Age >= 18);
        return result;
    }

    public static bool IsUserLoginFilled(User user) {
        bool result = !string.IsNullOrEmpty(user.Login);
        return result;
    }
}

class ProgramMain {
    static void CheckUserIsAdultAndLoginFilled(User user) {
        bool ok = new ChainCheckingsOfUser(user)
          .AddChecker(UserPropsChecker.IsUserAdult)
          .AddChecker(UserPropsChecker.IsUserLoginFilled)
          .RunCheck();
        Console.WriteLine($"{user.Login} {user.Age} {ok}");
    }

    static void Main() {
        CheckUserIsAdultAndLoginFilled(new User("Maxim", 26));
        CheckUserIsAdultAndLoginFilled(new User("Nina", 39));
        CheckUserIsAdultAndLoginFilled(new User("Alex", 9));
        CheckUserIsAdultAndLoginFilled(new User(string.Empty, 77));
        CheckUserIsAdultAndLoginFilled(new User(string.Empty, 9));
        CheckUserIsAdultAndLoginFilled(new User("George", 23));
    }
}


