<?php

	$method = $_SERVER['REQUEST_METHOD'];
	$body = file_get_contents('php://input');

	$db = pg_connect("host=10.0.2.27 user=postgres password= dbname=challenges");

	if ($method === "GET")
	{
		$messages = pg_fetch_all(pg_query($db, "SELECT * FROM chat_app.messages"));
		$formattedMessages = array_map(function ($message) 
			{ return "[{$message["timestamp"]}] ({$message["ip_address"]}) <{$message["user_name"]}> {$message["message"]}"; }, 
			$messages);

		echo json_encode($formattedMessages);
	}

	if ($method === "PUT")
	{
		$message = json_decode($body, true);

		$datetime = new DateTime("now", new DateTimeZone('America/Chicago'));

		pg_prepare($db, "",
			"INSERT INTO chat_app.messages (ip_address, user_name, message, timestamp) " .
			"VALUES ($1, $2, $3, $4)");
		pg_execute($db, "",
			[ $_SERVER['REMOTE_ADDR'], $message["user"], $message["message"], $datetime->format(DateTime::ATOM) ]);
	}

?>