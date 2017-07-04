namespace WindowsNavigator.Models
{
    public class ButtonProp
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Link { get; set; }

        public string Color { get; set; }

        public ButtonProp(int id , string text,string link,string color)
        {
            this.Id = id;
            this.Text = text;
            this.Link = link;
            this.Color = color;
        }
    }
}
