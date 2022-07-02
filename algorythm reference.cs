//algorithm
                double strdif = PlayerStats[0] - EnemyStats[0];
                double spddif = PlayerStats[1] - EnemyStats[1];
                double hpdif = PlayerStats[2] - EnemyStats[2];
                double totalstr = PlayerStats[0] + EnemyStats[0];
                double totalspd = PlayerStats[1] + EnemyStats[1];
                double totalhp = PlayerStats[2] + EnemyStats[2];
                double strvariation = (PlayerStats[0] / totalstr) * 100;
                double spdvariation = (PlayerStats[1] / totalspd) * 100;
                double hpvariation = (PlayerStats[2] / totalhp) * 100;
                double strvariationR = Convert.ToDouble(Math.Round(strvariation));
                double spdvariationR = Convert.ToDouble(Math.Round(spdvariation));
                double hpvariationR = Convert.ToDouble(Math.Round(hpvariation));

                Random rnumenemy = new Random();
                double randomstr = rnumenemy.Next(1, 100);
                double randomspd = rnumenemy.Next(1, 100);
                double randomhp = rnumenemy.Next(1, 100);
                double enemypoints = 0;
                double playerpoints = 0;
                //strength variation check
                if (strvariationR > randomstr)
                {
                    playerpoints += 1;
                    enemypoints += 0;
                }
                else if (strvariationR < randomstr)
                {
                    playerpoints += 0;
                    enemypoints += 1;
                }
                else if (strvariationR == randomstr)
                {
                    playerpoints += 0.5;
                    enemypoints += 0.5;
                }
                //speed variation check
                if (spdvariationR > randomspd)
                {
                    playerpoints += 1;
                    enemypoints += 0;
                }
                else if (spdvariationR < randomspd)
                {
                    playerpoints += 0;
                    enemypoints += 1;
                }
                else if (spdvariationR == randomspd)
                {
                    playerpoints += 0.5;
                    enemypoints += 0.5;
                }
                //hp variation check
                if (hpvariationR > randomhp)
                {
                    playerpoints += 1;
                    enemypoints += 0;
                }
                else if (strvariationR < randomhp)
                {
                    playerpoints += 0;
                    enemypoints += 1;
                }
                else if (hpvariationR == randomhp)
                {
                    playerpoints += 0.5;
                    enemypoints += 0.5;
                }

                double totalplayer = PlayerStats[0] + PlayerStats[1] + PlayerStats[2];
                double totalenemy = EnemyStats[0] + EnemyStats[1] + EnemyStats[2];
                double totalstats = totalenemy + totalplayer;
                double variation = (totalplayer / totalstats) * 100;
                double chance = Convert.ToDouble(Math.Round(variation));