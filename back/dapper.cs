using System.Collections.Generic;
using Godot;
using Microsoft.Data.Sqlite;
using Dapper;
using AccountModel;

public static class Database
{
    private static string DbPath =>
        ProjectSettings.GlobalizePath("user://data.db");

    private static SqliteConnection Open()
    {
        var c = new SqliteConnection($"Data Source={DbPath}");
        c.Open();
        return c;
    }

    public static void Init()
    {
        using var c = Open();
        c.Execute(
            """
            CREATE TABLE IF NOT EXISTS accounts (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                username TEXT NOT NULL UNIQUE,
                level INTEGER NOT NULL DEFAULT 1,
                streack INTEGER NOT NULL DEFAULT 0
            );

            CREATE INDEX IF NOT EXISTS idx_accounts_username
                ON accounts(username);
            """
        );
    }

    public static long CreateAccount(Account a)
    {
        using var c = Open();
        return c.ExecuteScalar<long>(
            """
            INSERT INTO accounts (username, level, streack)
            VALUES (@Username, @Level, @Streack)
            RETURNING id;
            """,
             a);
    }
}