using System;

class Seat
{
    private static int _totalUseCount;
    private static int _currentUse;

    static int _currentId = 1;

    int _id;
    string _name;

    public Seat(string student)
    {
        _id = _currentId++;
        _totalUseCount++; _currentUse++;
        _name = student;
        Console.WriteLine($"좌석 {_id}번 착석: {_name}");
    }

    public void Study()
    {
        Console.WriteLine($"{_name}이(가) 좌석 {_id}번에서 공부 중...");
    }

    static public void ShowStatus()
    {
        Console.WriteLine($"총 이용: {_totalUseCount}, 현재 착석: {_currentUse}명");
    }

    ~Seat()
    {
        _currentUse--;
        Console.WriteLine($"좌석 {_id}번 반납: {_name}");
    }
}