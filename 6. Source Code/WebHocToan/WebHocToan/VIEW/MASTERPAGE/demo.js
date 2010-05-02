$(document).ready(function(){
		
	
	
	// third example
	$("#red").treeview({
		animated: "slow",
		collapsed: true,
		unique: true,
		persist: "cookie",
		toggle: function() {
			window.console && console.log("%o was toggled", this);
		}
	});


});