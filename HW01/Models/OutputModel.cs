using System;
using HW01.Managers;


namespace HW01.Models
{
    class OutputModel
    {
        private UserModel _user;

        public OutputModel(UserModel user)
        {
            _user = user;
        }

        public int GetAge()
        {
            DateTime presentDay = DateTime.Today;
            int age = presentDay.Year - _user.Date.Year;

            if (_user.Date > presentDay.AddYears(-age)) age--;
 
            return _user.Age = age;
        }

        public string GetZodiacSign()
        {
            switch (_user.Date.Month)
            {
                case 1: _user.ZodiacSign = (_user.Date.Day <= 20) ? "Capricorn" : "Aquarius"; break;
                case 2: _user.ZodiacSign = (_user.Date.Day <= 19) ? "Aquarius" : "Pisces"; break;
                case 3: _user.ZodiacSign = (_user.Date.Day <= 20) ? "Pisces" : "Aries"; break;
                case 4: _user.ZodiacSign = (_user.Date.Day <= 20) ? "Aries" : "Taurus"; break;
                case 5: _user.ZodiacSign = (_user.Date.Day <= 21) ? "Taurus" : "Gemini"; break;
                case 6: _user.ZodiacSign = (_user.Date.Day <= 21) ? "Gemini" : "Cancer"; break;
                case 7: _user.ZodiacSign = (_user.Date.Day <= 22) ? "Cancer" : "Leo"; break;
                case 8: _user.ZodiacSign = (_user.Date.Day <= 23) ? "Leo" : "Virgo"; break;
                case 9: _user.ZodiacSign = (_user.Date.Day <= 23) ? "Virgo" : "Libra"; break;
                case 10: _user.ZodiacSign = (_user.Date.Day <= 23) ? "Libra" : "Scorpio"; break;
                case 11: _user.ZodiacSign = (_user.Date.Day <= 22) ? "Scorpio" : "Sagittarius"; break;
                case 12: _user.ZodiacSign = (_user.Date.Day <= 23) ? "Sagittarius" : "Capricorn"; break;
            }

            return _user.ZodiacSign;
        }

        public string GetChineseSign()
        {
            switch (_user.Date.Year % 12)
            {
                case 0: _user.ChineseSign = "Monkey"; break;
                case 1: _user.ChineseSign = "Rooster"; break;
                case 2: _user.ChineseSign = "Dog"; break;
                case 3: _user.ChineseSign = "Pig"; break;
                case 4: _user.ChineseSign = "Rat"; break;
                case 5:_user.ChineseSign = "Ram"; break;
                case 6:_user.ChineseSign = "Tiger"; break;
                case 7:_user.ChineseSign = "Rabbit"; break;
                case 8:_user.ChineseSign = "Dragon"; break;
                case 9:_user.ChineseSign = "Sneak"; break;
                case 10:_user.ChineseSign = "Horse"; break;
                case 11:_user.ChineseSign = "Ox"; break;
            }
            return _user.ChineseSign;
        }

        public bool IsBirthday()
        {
            return _user.Date.Day == DateTime.Today.Day && _user.Date.Month == DateTime.Today.Month;
        }

        public void Return()
        {
            NavigationManager.Instance.Navigate(DataHandlers.Input);
        }
    }


}
