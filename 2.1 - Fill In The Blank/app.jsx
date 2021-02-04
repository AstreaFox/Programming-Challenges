const { useState, useEffect, useLayoutEffect, useMemo, useRef, forwardRef } = React;
const { Switch, Route, Redirect, useHistory, useLocation, useRouteMatch } = ReactRouterDOM;

const App = p =>
{
	const history = useHistory();
	const location = useLocation();


	const [person_one, setPerson_one] = useState();
	const [adverb, setAdverb] = useState();
	const [opinion, setOpinion] = useState();
	const [person_two, setPerson_two] = useState();
	const [adjective, setAdjective] = useState();

	useEffect(() =>
	{
		setPerson_one("Fox");
		setAdverb("absolutely");
		setOpinion("loves");
	 	setPerson_two("Lily");
	 	setAdjective("Being the best teacher ever");
	}, [ location ]);

	return (
	<>
		<Rows marginSides="20%" minWidth={500} paddingSides={16}>
			<Row>
				<Box fontSize={32} marginBottom={32} marginTop={20}>
					For some unknown reason, {person_one} {adverb} {opinion} {person_two} for {adjective}. To this day, no one else knows why...
				</Box> 
				<Boxes marginBottom={14}>
					<Box><TextInput label="Person One" value={person_one} onChange={e => setPerson_one(e.target.value)}/></Box>
					<Box><TextInput label="Adverb" value={adverb} onChange={e => setAdverb(e.target.value)}/></Box>
					<Box><TextInput label="Opinion" value={opinion} onChange={e => setOpinion(e.target.value)}/></Box>
					<Box><TextInput label="Person Two" value={person_two} onChange={e => setPerson_two(e.target.value)}/></Box>
					<Box><TextInput label="Adjective" value={adjective} onChange={e => setAdjective(e.target.value)}/></Box>
				</Boxes>
			</Row>
		</Rows>
	</>);
};
