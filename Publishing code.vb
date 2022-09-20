if(
    prop("Is it a weekend?")==true, 

    if(
        formatDate(prop("Publication date"), "ddd") == "Sat", 
        dateSubtract(prop("Publication date"), 3, "days"), 
        dateSubtract(prop("Publication date"), 4, "days")
    ), 

    prop("2 days before")
)