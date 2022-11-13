using AIMLbot;

namespace Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void humanMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bot bot = new Bot();
            bot.loadSettings(); //Loads the files from the config folder
            bot.loadAIMLFromFiles(); //Loads the files from the aiml folder
            bot.isAcceptingUserInput = false;

            User newUser = new User("Username",bot);
            bot.isAcceptingUserInput = true;

            Request newRequest = new Request(humanMessage.Text, newUser,bot); //Reads the message that the user inputted
            Result newResult = bot.Chat(newRequest); //The bot will then get this message the user inputs and the result will be stored here

            AI_Message.Text = "Output: " + newResult.Output; //Sends the AI message in this format and outputs the result message 

        }
    }
}