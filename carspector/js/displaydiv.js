

/*
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
        "500 km", "1,000 km",
        "2,000 km", "3,000 km",
        "5,000 km", "7,000 km","10,000 km"
        "above 10,000"
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

*/
 	var budgetArray = new Array();
	budgetArray['2 lakh'] = "200000";
	budgetArray['5 lakh'] = "500000";
	budgetArray['10 lakh'] = "1000000";
	budgetArray['20 lakh'] = "2000000";
	budgetArray['30 lakh'] = "3000000";
	budgetArray['50 lakh'] = "5000000";
	budgetArray['75 lakh'] = "7500000";
	budgetArray['1 crore'] = "10000000";
	budgetArray['2 crore'] = "20000000";
	budgetArray['above 3 crore'] = "500000000";
	
	
	var kmArray = new Array();
	kmArray['500'] = "500";
	kmArray['1,000'] = "1000";
	kmArray['2,000'] = "2000";
	kmArray['3,000'] = "3000";
	kmArray['5,000'] = "5000";
	kmArray['7,000'] = "7000";
	kmArray['10,000'] = "10000";
	kmArray['above 10,000'] = "200000";
    

    var typeArray = new Array();
    typeArray['Daily use'] = "1";
    typeArray['weekend trips'] = "2";
    typeArray['performance'] = "3";
    typeArray['utility'] = "4";





   var budget = document.getElementById("range_budget").value;
   console.log(budget);

   console.log(budgetArray[budget]);

  
  var km = document.getElementById("range_km").value;
   console.log(km);

   var type = document.getElementById("range_type").value;
   console.log(type);

   
   showDivs('results');


    $("#filteradder").click(function(){

  
   
   showDivs('addFilters');
});
    