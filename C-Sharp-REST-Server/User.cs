namespace C_Sharp_REST
{
    class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int role { get; set; }

        public override string ToString()
        {
            return "[" 
                + "id=" + id + ","
                + "name=" + name + ","
                + "email=" + email + ","
                + "phone=" + phone + ","
                + "role=" + role
                + "]";
        }

    }
}
