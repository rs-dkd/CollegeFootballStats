﻿using CollegeFootballStats.Importer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeFootballStats.Importer
{
    internal class TeamResponse
    {
        public int Id { get; set; }
        public string School { get; set; }

        // yes...abbreviation is nullable in the api...guessing we wont use those teams much
        public string? Abbreviation { get; set; }
    }

    internal class CoachResponse
    {
        // Gotta have the dumb underscores because that
        // is what the api returns
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public List<CoachSeason> Seasons { get; set; }
        public CoachResponse()
        {
            Seasons = new List<CoachSeason>();
        }

    }

    internal class CoachSeason
    {
        // The give us the school name in the api, but we need the id
        // so we will have to look it up
        public string School { get; set; }
        public int Year { get; set; }
        public int Games { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Ties { get; set; }
    }

    internal class GameResponse
    {
        public int Id { get; set; }
        public int Season { get; set; }
        public int Week { get; set; }
        public DateTime Start_Date { get; set; }
        public int Home_Id { get; set; }
        public string Home_Team { get; set; }
        public int? Home_Points { get; set; }
        public int Away_Id { get; set; }
        public string Away_Team { get; set; }
        public int? Away_Points { get; set; }
        public bool Completed { get; set; }
        public string Season_Type { get; set; }
    }

    internal class ConferenceResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Short_Name { get; set; }
        public string? Classification { get; set; }
        public string? Abbreviation { get; set; }
    }

    internal class RosterResponse
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public int? Jersey { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public int? Year { get; set; }
    }
}

internal class PollResponse
{
    public int Season { get; set; }
    public string SeasonType { get; set; }
    public int Week { get; set; }
    public List<ActualPolls> Polls { get; set; }
    public PollResponse()
    {
        Polls = new List<ActualPolls>();
    }
}

internal class ActualPolls
{
    public string Poll { get; set; }
    public List<PollRankings> Ranks { get; set; }
    public ActualPolls()
    {
        Ranks = new List<PollRankings>();
    }
}

internal class PollRankings
{
    public int Rank { get; set; }
    public string School { get; set; }
}
