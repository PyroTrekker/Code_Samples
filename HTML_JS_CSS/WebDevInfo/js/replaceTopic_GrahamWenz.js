$(document).ready(function() {

    // Reference Variables
    var $activeTab = $('header nav ul li a'), // Currently clicked tab
        $subjectTopic = $('#subjectTab span#topic'), // Topic text to change
        $subjectTabs = $('#content .contentContainer'),
		$contentHeight = $('#content').height(), // Returns an integer representing the height of div#content
		$contentBar = $('#contentWrap, #leftSideBar'),
		subtractHeight = - 5;
		
		setHeight = function(heightPlusMinus) {
			
			var heightDir = heightPlusMinus;
			
			$contentBar.css('height', $contentHeight + heightDir);
			
		};
		
		
		setHeight(subtractHeight);
		
    
    $activeTab.click(function() {
    
        var $self = $(this), // Store a reference to 'this' before it changes
            $tabText = $self.text(), // The text of the current element
            $tabID = $self.attr('id'), // The id of the current element
            $newTab = $('#' + $self.attr('id') + 'Tabs'),
			addHeight = + 170; /* Get a reference to the content tab that cooresponds to the currently
            active (clicked) navigation tab.*/
        
		// Set the height
		if ($self.attr('id') == 'jquery') {
		
			setHeight(subtractHeight);
		
		}
		else {
		
			setHeight(addHeight);
		
		}
		
		
        /* Hide the current content tab and slide the content tab that cooresponds to the currently active
           navigation tab into view */
        $subjectTabs.hide(0.1).filter($newTab).slideDown(1000);
       
        // Fade out the current topic text
        $subjectTopic.fadeOut(500, function() {
            
            /* Set the topic text to coorespond to the currently active
            navigation tab */
            $subjectTopic.text($tabText);
            
            // Fade the topic text back in
            $subjectTopic.fadeIn(500);
            
        }); // End fadeOut()
        
    }); // End click()

}); // End ready()