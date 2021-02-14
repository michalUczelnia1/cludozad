
            foreach (Person p1 in people)
            {
                if (p1.Age<=20)
                {
                    foreach (Company c1 in companies)
                    {
                        if (c1.ID==p1.CompanyID)
                        {
                            companies.Remove(c1);
                        }
                    }
                }
            }