﻿namespace Hotelproject.WebUI.Models.Booking;

public class AddBookingModel
{
    public string Name { get; set; }
    public string Mail { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public string AdultCount { get; set; }
    public string ChildCount { get; set; }
    public string RoomCount { get; set; }
    public string SpecailRequest { get; set; }
    public string Status { get; set; }

}