const { useState, useEffect, useLayoutEffect, useMemo, useRef, forwardRef } = React;
const { Switch, Route, Redirect, useHistory, useLocation, useRouteMatch } = ReactRouterDOM;

const App = p =>
{
	const history = useHistory();
	const location = useLocation();

	const [noun, setNoun] = useState();
	const [verb, setVerb] = useState();
	const [adjective, setAdjective] = useState();

	useEffect(() =>
	{
		setNoun("dog");
		setVerb("jumped");
		setAdjective("brown");
	}, [ location ]);

	return (
	<>
		<Rows marginSides="20%" minWidth={500} paddingSides={16}>
			<Row>
				<Box fontSize={32} marginBottom={32} marginTop={20}>
					The quick {adjective} fox {verb} over the lazy {noun}.
				</Box> 
				<Boxes marginBottom={14}>
					<Box><TextInput label="Adjective" value={adjective} onChange={e => setAdjective(e.target.value)}/></Box>
					<Box><TextInput label="Verb" value={verb} onChange={e => setVerb(e.target.value)}/></Box>
					<Box><TextInput label="Noun" value={noun} onChange={e => setNoun(e.target.value)}/></Box>
				</Boxes>
			</Row>
		</Rows>
	</>);
};
