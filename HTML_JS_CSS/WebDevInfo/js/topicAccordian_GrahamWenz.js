$(document).ready(function() {

	// Reference Variables
    var $accordionLi = $('ul#accordion > li'),
        $accordionLiUl = $accordionLi.children('> ul');
        
    // Hide all ul's that are direct children of ul#accordion li
    $accordionLiUl.hide(0.1);
	
    // Set up a click event on each li
    $accordionLi.each(function() {
        
        $(this).click(function() {
	
            // Store a reference to $(this) in case it changes
            $self = $(this);
		
            /* Find the parent of this li and select 
            any direct children li's that have a 
            child <ul> that is currently visible (open) */
            var $visibleSiblings = $self.parent('ul').children('li').children('ul:visible'),
		
			// find the first ul that is a child of the clicked li
			$nextUl = $self.find('ul:first');
		
            /* If $nextUl is not currently visible and there is at  
              least one $visibleSibling... */
            if ($nextUl.is(':hidden') && $visibleSiblings.length ){
                
                // hide any open ul's and slide down $nextUl				
                $visibleSiblings.slideToggle(function() {
				
					$nextUl.slideToggle();
				
				});                
			
            } 
            else {
		
                $nextUl.slideToggle();
		
            };
	
        });

    });

});