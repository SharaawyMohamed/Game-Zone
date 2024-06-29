﻿using Microsoft.EntityFrameworkCore;

namespace GameZone.Data
{
	public class GameDbContext:DbContext
	{
        public GameDbContext(DbContextOptions<GameDbContext> options):base(options)
        {
            
        }
    }
}
