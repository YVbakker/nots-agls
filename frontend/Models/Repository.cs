﻿namespace frontend.Models;

public class Repository
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
}

public class GitRepoCreateDto
{
    public string Name { get; set; }
    public string Url { get; set; }
}

public class RepositoriesCsv
{
    public string csvData { get; set; }
}