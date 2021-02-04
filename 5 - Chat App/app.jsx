const { useState, useEffect, useLayoutEffect, useMemo, useRef, forwardRef } = React;
const { Switch, Route, Redirect, useHistory, useLocation, useRouteMatch } = ReactRouterDOM;

const App = p =>
{
	const history = useHistory();
	const location = useLocation();

	const [user, setUser] = useState("");
	const [messageToSend, setMessageToSend] = useState("");
	const [messages, setMessages] = useState([]);

	useEffect(() =>
	{
		const timer = setInterval(() =>
		{
			fetch("http://localhost/messages")
				.then(response => response.json())
				.then(json => setMessages(
					json.map(msg => `[${msg.time}] ${msg.user}: ${msg.message}`)));
		}, 500);

		return () => clearInterval(timer);
	}, []);

	const SendMessage = () =>
	{
		const time = luxon.DateTime.local().toFormat("yyyy-MM-dd HH:mm:ss");

		// prevents literal interpretation of special char, e.g. &, !, !=, ?.
		fetch(`http://localhost/message?` +
			`time=${encodeURIComponent(time)}&` +
			`user=${encodeURIComponent(user)}&` +
			`message=${encodeURIComponent(messageToSend)}`);
		
		setMessageToSend("");
	};

	return (
	<>
		<Rows marginSides="10%" minWidth={1000} paddingSides={16}>
			<Row>
				<Box fontSize={24} marginBottom={10}>Fox &gt; Austin, message count = {messages.length}</Box>
				<Box height={600} marginBottom={10} backgroundColor="#ddd" whiteSpace="pre">{messages.join("\n")}</Box>
				<Box width="100%">
					<Span marginRight={10} width={100}>
						<Box marginBottom={6}>Username</Box>
						<TextInput value={user} onChange={e => setUser(e.target.value)} width="100%"/>
					</Span>
					<Span marginRight={10} width="calc(100% - 170px)">
						<Box marginBottom={6}>Message</Box>
						<TextInput value={messageToSend} onChange={e => setMessageToSend(e.target.value)}
							onKeyUp={e => { if (e.key === 'Enter') SendMessage(); }} width="100%"/>
					</Span>
					<Span width={50}>
						<Box marginBottom={6}>&nbsp;</Box>
						<Button onClick={e => SendMessage()} width="100%">Send</Button>
					</Span>
				</Box>
			</Row>
		</Rows>
	</>);
};
