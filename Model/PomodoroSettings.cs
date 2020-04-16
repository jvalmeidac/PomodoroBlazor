using System.ComponentModel.DataAnnotations;

namespace PomodoroBlazor.Model
{
    public class PomodoroSettings
    {

        [Required(ErrorMessage = "Especifique o tempo de duração!")]
        [Range(1, 60, ErrorMessage = "O valor deve ser entre 1 e 60 minutos!")]
        public int PomodoroDuration { get; set; }


        [Range(1, 15, ErrorMessage = "O valor deve ser entre 1 e 15 minutos!")]
        public int ShortBreak { get; set; }


        [Range(15, 60, ErrorMessage = "O valor deve ser entre 15 e 60 minutos!")]
        public int LongBreak { get; set; }
    }

    public enum TimerType
    {
        Pomodoro = 1,
        ShortBreak = 2,
        LongBreak = 3
    }
}
