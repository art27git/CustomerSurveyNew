$(document).ready(function(e){

	$('.focos li').click(function(e) {
		var ob = $(this).attr('class');
		
		if(ob == 'foco_1'){
			$(this).find('img').attr('src', '/Content/images/foco_1_b.png');
			$('.focos li.foco_2').find('img').attr('src', '/Content/images/foco_2_a.png');
			$('.focos li.foco_3').find('img').attr('src', '/Content/images/foco_3_a.png');
		}else if(ob == 'foco_2'){
		    $(this).find('img').attr('src', '/Content/images/foco_2_b.png');
		    $('.focos li.foco_1').find('img').attr('src', '/Content/images/foco_1_a.png');
		    $('.focos li.foco_3').find('img').attr('src', '/Content/images/foco_3_a.png');
		}else if(ob == 'foco_3'){
		    $(this).find('img').attr('src', '/Content/images/foco_3_b.png');
		    $('.focos li.foco_1').find('img').attr('src', '/Content/images/foco_1_a.png');
		    $('.focos li.foco_2').find('img').attr('src', '/Content/images/foco_2_a.png');
		}
	});
	
})