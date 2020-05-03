<head>
	<meta name="viewport" content="width=device-width,height=device-height,initial-scale=1.0"/>
</head>
<style>
	h2{
		font-family: poppinslight, sans-serif;
	    text-align: center;
		background-color: darkred;
		color: white;
		border-width: 1px;
		border-style: solid;
		border-radius: 5px;
	    padding: .4em .5em;
	    margin: 2px 2px 2px 0;
	}

	h2:hover{
	  box-shadow: 2px 2px black;
	  top: -2px;
	  right: 2px;
	  border-color: white;
	}
</style>
<?php
    $FileName = $_GET['FileName'];
	
	$fileName = basename($FileName);
	$filePath = 'outputs/'.$fileName;
	
	if(!empty($fileName) && file_exists($filePath)){
		// Define headers
		header("Cache-Control: public");
		header("Content-Description: File Transfer");
		header("Content-Disposition: attachment; filename=$fileName");
		header("Content-Type: application/zip");
		header("Content-Transfer-Encoding: binary");
		
		ob_clean();
		flush();
		
		// Read File and then delete it
		if (readfile($filePath))
		{
			unlink($filePath);
		}
			
		exit;
	}
	else
	{
		echo '<h2>The file does not exist.. Please try exporting again.</h2>';
	}
?>