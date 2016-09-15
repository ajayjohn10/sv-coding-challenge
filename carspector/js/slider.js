         
    $(document).ready(function () {


    $("#range_budget").ionRangeSlider({
    grid: true,
    from: 0,
    values: [
        "2 lakh", "5 lakh",
        "10 lakh", "20 lakh",
        "30 lakh", "50 lakh",
        "75 lakh", "1 crore",
        "2 crore", "3 crore",
        "above 3 crore"
    ]
    }); 

    $("#range_km").ionRangeSlider({
    grid: true,
    from: 0,
    values: [
        "1,000 km", "2,000 km",
        "4,000 km", "6,000 km",
        "10,000 km", "20,000 km",
        "above 20,000"
    ]
    }); 

    $("#range_type").ionRangeSlider({
    grid: true,
    from: 0,
    values: [
        "Daily use", "weekends trips",
        "performance", "utility"
        
    ]
    }); 

    $(".range_filter").ionRangeSlider({
    grid: true,
    from: 0,
    values: [
        "0", "1","2", "3", "4", "5", "6", "7", "8", "9"
        
        ]
        }); 


    });
    